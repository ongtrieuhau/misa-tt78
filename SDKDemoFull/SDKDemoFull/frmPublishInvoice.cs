using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using API3.SDK.Model.SDKResult;
using API3.SDK.Model.Parameter;
using API3.SDK.Interface;
using API3.SDK;
using API3.SDK.SignUtils;
using System.Xml;
using API3.SDK.Model;

namespace SDKDemo
{
    public partial class frmPublishInvoice : Form
    {
        /// <summary>
        /// khai báo đối tượng list mẫu hóa đơn
        /// </summary>
        List<TemplateData> templateList = null;
        /// <summary>
        /// khai báo đối tượng danh sách hàng hóa dịch vụ
        /// </summary>
        List<OriginalInvoiceDetail> detail = new List<OriginalInvoiceDetail>();
        /// <summary>
        /// khai báo danh sách thuế suất của hóa đơn
        /// </summary>
        List<TaxRateInfo> TaxRateInfolist = new List<TaxRateInfo>();
        /// <summary>
        /// khai báo đối tượng hóa đơn chưa phát hành
        /// </summary>
        IInvoicePublishing InvoicePublishingObject = null;

        IInvoicePublished IInvoicePublishedObject = null;

        public frmPublishInvoice()
        {
            InitializeComponent();
            // Tạo đối tượng hóa đơn chưa phát hành
            InvoicePublishingObject = MeInvoiceFactory.CreateInvoicePublishingClass(Session.TaxCode, Session.Token);
            //Tạo đối tượng hóa đơn đã phát hành
            IInvoicePublishedObject = MeInvoiceFactory.CreateInvoicePublishedClass(Session.TaxCode, Session.Token);
            // Gán các thông tin người bán
            txtSellerTaxCode.Text = Session.TaxCode;
            txtSellerName.Text = "Công ty cổ phần MISA TEST - " + Session.TaxCode;
        }

        /// <summary>
        /// Lấy danh sách mẫu hóa đơn
        /// </summary>
        private void InitInvoiceTemplateCombo()
        {
            // Gọi SDK để lấy về danh sách mẫu hóa đơn
            var oResult = InvoicePublishingObject.GetInvoiceTemplateForPublish(DateTime.Now.Year, Session.IsInvoiceCode);
            // kiểm tra và gán mẫu hóa đơn cào combobox
            if (oResult.Success)
            {
                templateList = oResult.TemplateDatas;
                foreach (TemplateData item in templateList)
                {
                    cboKyHieu.Items.Add(item.InvSeries);
                }
            }
            else
            {
                // Thông báo mã lỗi nếu có
                Common.ShowMessage(oResult.ErrorCode);
            }

        }

        /// <summary>
        /// Gán giá trị cho object hóa đơn 
        /// </summary>
        /// <returns></returns>
        private OriginalInvoiceData BuildOriginalInvoiceData()
        {
            // khai báo đối tượng hóa đơn 
            OriginalInvoiceData invoiceData = new OriginalInvoiceData();
            // thông tin ID, tên hóa đơn, Ký hiệu
            invoiceData.RefID = Guid.NewGuid().ToString();
            invoiceData.InvoiceName = "HÓA ĐƠN GIÁ TRỊ GIA TĂNG";
            invoiceData.InvSeries = cboKyHieu.Text;
            invoiceData.InvDate = DateTime.Now.Date;
            // thông tin đáng dấu có phải hóa đơn nạp qua cơ quan thuế bằng bảng tổng hợp hay không
            invoiceData.IsInvoiceSummary = false;
            // thông tin người bán và người mua
            invoiceData.SellerTaxCode = txtSellerTaxCode.Text;
            invoiceData.SellerLegalName = txtSellerName.Text;
            invoiceData.SellerAddress = txtSellerAddress.Text;
            invoiceData.BuyerTaxCode = txtBuyerTaxCode.Text;
            invoiceData.BuyerLegalName = txtBuyerName.Text;
            invoiceData.BuyerAddress = txtBuyerAddress.Text;
            invoiceData.BuyerEmail = txtReceiverEmail.Text;
            invoiceData.ContactName = txtReceiverName.Text;
            //thông tin hóa đơn thay thế hoặc điều chỉnh 
            if (rbAdjust.Checked)
            {
                invoiceData.ReferenceType = 2;
                invoiceData.OrgInvoiceType = 1;
                invoiceData.OrgInvNo = txtNumberOrg.Text;
                invoiceData.OrgInvTemplateNo = cboKyHieu.Text.Substring(0, 1);
                invoiceData.OrgInvSeries = cboKyHieu.Text;
                invoiceData.OrgInvDate = dteOrgDate.Value.Date;
            }
            else if (rbReplace.Checked)
            {
                invoiceData.ReferenceType = 1;
                invoiceData.OrgInvoiceType = 1;
                invoiceData.OrgInvNo = txtNumberOrg.Text;
                invoiceData.OrgInvTemplateNo = cboKyHieu.Text.Substring(0, 1);
                invoiceData.OrgInvSeries = cboKyHieu.Text;
                invoiceData.OrgInvDate = dteOrgDate.Value.Date;
            }
            //thông tin các trương mở rộng
            invoiceData.CustomField1 = "1";
            invoiceData.CustomField2 = "2";
            invoiceData.CustomField3 = "3";
            invoiceData.CustomField4 = "4";
            invoiceData.CustomField5 = "5";
            invoiceData.CustomField6 = "6";
            invoiceData.CustomField7 = "7";
            invoiceData.CustomField8 = "8";
            invoiceData.CustomField9 = "9";
            invoiceData.CustomField10 = "10";
            bsDetail.EndEdit();
            // thông tin hàng hóa dịch vụ
            invoiceData.OriginalInvoiceDetail = detail;
            // khai báo và gán giá trị cho đối tượng thuế suất
            TaxRateInfo TaxRateInfoitem = new TaxRateInfo();
            TaxRateInfoitem.VATRateName = "10%";
            TaxRateInfoitem.AmountWithoutVATOC = 150000;
            TaxRateInfoitem.VATAmountOC = 15000;
            TaxRateInfolist.Add(TaxRateInfoitem);
            // gán đối tượng thuế suất vào đối tượng hóa đơn
            invoiceData.TaxRateInfo = TaxRateInfolist;
            // thông tin tổng tiền  hàng, tổng tiền thuế, tổng tiền thanh toán, hình thức thanh toán, số tiền bằng chữ
            // tiền nguyên tệ
            invoiceData.TotalSaleAmountOC = 150000;//tiền bán hàng nguyên tệ
            invoiceData.TotalDiscountAmountOC = 0;
            invoiceData.TotalAmountWithoutVATOC = invoiceData.TotalSaleAmountOC - invoiceData.TotalDiscountAmountOC;// tiền trước thuế  nguyên tệ
            invoiceData.TotalVATAmountOC = 15000;// tiền thuế  nguyên tệ
            invoiceData.TotalAmountOC = 165000;//thành tiền nguyên tệ


            invoiceData.TotalAmountInWords = SayMoney.MISASaysMoney.MISASayMoney(1522323.12M).Replace("  ", " ");
            // loại tiền và tỷ giá quy đổi
            invoiceData.CurrencyCode = "VND";
            invoiceData.ExchangeRate = 1;
            invoiceData.PaymentMethodName = "TM/CK";
            // thông tin tổng tiền quy đổi
            invoiceData.TotalSaleAmount = invoiceData.TotalSaleAmountOC * invoiceData.ExchangeRate;//tiền bán hàng quy đổi
            invoiceData.TotalDiscountAmount = invoiceData.TotalDiscountAmountOC * invoiceData.ExchangeRate;
            invoiceData.TotalAmountWithoutVAT = invoiceData.TotalAmountWithoutVATOC * invoiceData.ExchangeRate;// tiền trước thuế  quy đổi
            invoiceData.TotalVATAmount = invoiceData.TotalVATAmountOC * invoiceData.ExchangeRate;// tiền thuế  quy đổi
            invoiceData.TotalAmount = invoiceData.TotalAmountOC * invoiceData.ExchangeRate;//thành tiền quy đổi
            invoiceData.TotalAmountWithoutVAT = invoiceData.TotalAmountWithoutVATOC * invoiceData.ExchangeRate;// thành tiền sau thuế  quy đổi
            // thông tin định dạng số thập phân hiển thị lên mẫu hóa đơn
            invoiceData.OptionUserDefined = new OptionUserDefined()
            {
                MainCurrency = "VND",
                AmountDecimalDigits = "2",
                AmountOCDecimalDigits = "2",
                CoefficientDecimalDigits = "2",
                ExchangRateDecimalDigits = "2",
                QuantityDecimalDigits = "3",
                UnitPriceDecimalDigits = "2",
                UnitPriceOCDecimalDigits = "2",
                ClockDecimalDigits = "4"
            };
            return invoiceData;
        }

        private void frmPublishInvoice_Shown(object sender, EventArgs e)
        {
            try
            {
                InitInvoiceTemplateCombo();
                // khai báo thông tin hàng hóa dich vụ, gắn lên grid ở form
                // tỷ giá lấy ở thông tin OriginalInvoiceData giá trị cho VND là 1.
                OriginalInvoiceDetail newDetail = new OriginalInvoiceDetail();
                newDetail.LineNumber = 1;
                newDetail.SortOrder = 1;
                newDetail.ItemType = 1;// kiểu hàng hóa (1: HHDV; 2: khuyến mại; 3: chiết khẩu; 4: ghi chú/diễn giải)
                newDetail.ItemCode = "AO-NAM";
                newDetail.ItemName = "Áo nam";
                newDetail.UnitName = "Chiếc";
                newDetail.Quantity = 1;
                newDetail.UnitPrice = 150000;
                newDetail.AmountOC = 150000;// thành tiền nguyên tệ
                newDetail.Amount = newDetail.AmountOC * 1;// thành tiền nguyên tệ nhân tỷ giá
                newDetail.DiscountRate = 0;
                newDetail.DiscountAmountOC = 0;// tiền chiết khấu nguyên tệ
                newDetail.DiscountAmount = newDetail.DiscountAmountOC * 1;// tiền chiết khấu quy đổi
                newDetail.AmountWithoutVATOC = newDetail.AmountOC - newDetail.DiscountAmountOC;// thành tiền trước thuế
                newDetail.VATRateName = "10%";// tên thuế suất (10%,5%,0%,KCT,KKKNT,KHAC:X.XX% (X: số tự nhiên ví dụ : KHAC:7.00%))
                newDetail.VATAmountOC = 15000;
                newDetail.VATAmount = newDetail.VATAmountOC * 1;
                //thêm đối tượng detail
                detail.Add(newDetail);

                bsDetail.DataSource = detail;
                gvDetail.DataSource = bsDetail;
                pnlSignFile.Dock = DockStyle.Bottom;
                pnlSignServer.Dock = DockStyle.Bottom;
                dteOrgDate.Value = DateTime.Now.Date;
            }
            catch (Exception ex)
            {
                Common.ShowException(ex);
            }
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                // Khai báo đôi tượng list hóa đơn cần phát hành
                List<OriginalInvoiceData> lstData = new List<OriginalInvoiceData>();
                // Lấy giá trị trên form gán vào đối tượng hóa đơn
                OriginalInvoiceData invoiceData = BuildOriginalInvoiceData();
                // Khai báo đối tượng hóa đơn khi tạo xml thô trả về
                ListCreateInvoiceDataResult InvoiceDataResult = new ListCreateInvoiceDataResult();
                // Khai báo đối tượng khi phát hành hóa đơn trả về
                ListPublishInvoiceResult PublishInvoiceResult = new ListPublishInvoiceResult();
                // Khai báo list đối tượng cần đem đi phát hành
                List<PublishInvoiceData> lstPublishInvoiceData = new List<PublishInvoiceData>();
                // khai báo đối tượng HD cần phát hành
                PublishInvoiceData PublishInvoiceData = new PublishInvoiceData();
                // thêm đối tượng hóa đơn vào list hóa đơn cần phát hành
                lstData.Add(invoiceData);
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(invoiceData);
                if (rbSignDirect.Checked || rbSignServer.Checked || rbSignFile.Checked)
                {
                    //Ký trực tiếp và ký qua server
                    // tạo hóa đơn xml dạng thô
                    InvoiceDataResult = InvoicePublishingObject.CreateInvoiceData(lstData, Session.IsInvoiceCode);
                    //kiểm trá kết quả trả về thành công không, có xml không. nếu không báo mã lỗi trả về
                    if (InvoiceDataResult.ErrorCode == "" && InvoiceDataResult.CreateInvoiceDatas.Count > 0)
                    {
                        // kiểm tra lỗi trong nội dung json không có thì đem đi ký
                        if (string.IsNullOrEmpty(InvoiceDataResult.CreateInvoiceDatas[0].ErrorCode))
                        {
                            // Khai báo đối tượng xml chưa xml thô được trả về
                            XmlDocument XmlData = new XmlDocument();
                            // gán xml dạng string được trả về khi tạo xml thô
                            XmlData.LoadXml(InvoiceDataResult.CreateInvoiceDatas[0].InvoiceData);
                            // kiểm tra xem đang là ký trực tiếp hay ký qua tool ký
                            if (rbSignServer.Checked)
                            {
                                // PHƯƠNG THỨC KÝ QUA TOOL KÝ.
                                // tên máy chủ ký số
                                // mã pin của Chứng thư số
                                // file xml cần ký
                                // cổng port của tool ký
                                var oResultSignXML = SignXmlUtil.SignXMLByTool(txtSign_Name.Text, txtSign_Pin.Text, XmlData, "12019");
                                if (!string.IsNullOrEmpty(oResultSignXML.Data))
                                {
                                    XmlData.LoadXml(oResultSignXML.Data);
                                }
                                else
                                {
                                    Common.ShowMessage("Ký SignService XML lỗi, Mã lỗi: " + oResultSignXML.Error);
                                    return;
                                }
                            }
                            else if (rbSignDirect.Checked)
                            {
                                //PHƯƠNG THỨC KÝ TRỰC TIẾP
                                // Gọi SDK để show chọn CTS được cài trên máy
                                X509Certificate2 cert = SignXmlUtil.GetCertificateFromStore();
                                // truyền các giá trị vào hàm ký số để ký
                                SignXmlUtil.SignXml(XmlData, cert);
                            }
                            else if (rbSignFile.Checked)
                            {
                                //PHƯƠNG THỨC KÝ QUA FILE MỀM
                                // 1. XML cần ký
                                // 2. Đường dẫn file mềm token (full name path vs file name)
                                // 3. Mật khẩu file mềm
                                var oResultSignXML = SignXmlUtil.SignXMLByFile(XmlData, txtFilePath.Text, txtPINFile.Text);
                                if (!string.IsNullOrEmpty(oResultSignXML.Data))
                                {
                                    XmlData.LoadXml(oResultSignXML.Data);
                                }
                                else
                                {
                                    Common.ShowMessage("Ký file XML lỗi, Mã lỗi: " + oResultSignXML.Error);
                                    return;
                                }
                            }

                            // Gán giá trị cho đối tượng gọi đi phát hành
                            PublishInvoiceData.InvoiceData = XmlData.InnerXml;
                            PublishInvoiceData.RefID = InvoiceDataResult.CreateInvoiceDatas[0].RefID;
                            PublishInvoiceData.TransactionID = InvoiceDataResult.CreateInvoiceDatas[0].TransactionID;
                            // Kiểm tra có tùy chọn gửi mail kèm phát hành hay không
                            if (chkSendEmail.Checked)
                            {
                                // biến đánh dấu gửi mail kèm phát hành
                                PublishInvoiceData.IsSendEmail = true;
                                // các email được gửi email tới
                                PublishInvoiceData.ReceiverEmail = txtReceiverEmail.Text;
                                // tên người nhận email
                                PublishInvoiceData.ReceiverName = txtReceiverName.Text;
                            }
                            lstPublishInvoiceData.Add(PublishInvoiceData);
                            // Phát hành hóa đơn lên hệ thống MISA
                            PublishInvoiceResult = InvoicePublishingObject.PublishInvoice(lstPublishInvoiceData, Session.IsInvoiceCode);

                        }
                        else
                        {
                            Common.ShowMessage("Tạo XML lỗi, Mã lỗi: " + InvoiceDataResult.CreateInvoiceDatas[0].ErrorCode);
                        }

                    }
                    else
                    {
                        Common.ShowMessage("API tạo XML lỗi, Mã lỗi: " + InvoiceDataResult.ErrorCode);
                    }
                }
                else if (rbSignHSM.Checked)
                {
                    // Nếu ký qua HSM thì tạo đối tượng ký HSM

                }
                else
                {
                    MessageBox.Show("Chưa chọn phương thức ký nào.");
                    return;
                }

                // kiểm tra xem hàm phát hành thành công hay chưa. nếu lỗi báo theo mã lỗi phía dưới
                if (PublishInvoiceResult.Success && PublishInvoiceResult.ErrorCode == "")
                {
                    // đối tượng nhận kết quả khi phát hành trả về
                    List<PublishInvoice> pubResult = PublishInvoiceResult.PublishInvoices;
                    // kiểm tra có đối tượng phát hành trả về không
                    if (pubResult != null && pubResult.Count > 0)
                    {
                        // kiểm tra có mã lỗi trả về không
                        if (string.IsNullOrEmpty(pubResult[0].ErrorCode))
                        {
                            //show các thông tin hóa đơn đã phát hành thành công được trả về
                            StringBuilder messageBuilder = new StringBuilder();
                            messageBuilder.AppendFormat("Phát hành hóa đơn thành công.{0}", Environment.NewLine);
                            messageBuilder.AppendFormat("Mã tra cứu: {0}{1}", pubResult[0].TransactionID, Environment.NewLine);
                            messageBuilder.AppendFormat("Số hóa đơn: {0}{1}", pubResult[0].InvNo, Environment.NewLine);
                            messageBuilder.AppendFormat("Ngày hóa đơn: {0}{1}", pubResult[0].InvDate, Environment.NewLine);

                            txtNumberOrg.Text = pubResult[0].InvNo;
                            dteOrgDate.Value = pubResult[0].InvDate.Date;

                            using (Form frm = new Form())
                            {
                                RichTextBox rtb = new RichTextBox();
                                rtb.Text = messageBuilder.ToString();
                                rtb.Dock = DockStyle.Fill;
                                frm.Controls.Add(rtb);
                                frm.StartPosition = FormStartPosition.CenterScreen;
                                frm.ShowDialog();
                            }
                        }
                        else
                        {
                            //Phát hành không thành công, show mã lỗi trả về
                            switch (pubResult[0].ErrorCode)
                            {
                                case ErrorCode.SignatureEmpty:
                                    Common.ShowMessage("File chưa được ký");
                                    break;
                                case ErrorCode.InvalidSignature:
                                    Common.ShowMessage("Chữ ký số không hợp lệ");
                                    break;
                                case ErrorCode.InvalidXMLData:
                                    Common.ShowMessage("Dữ liệu XML hóa đơn không hợp lệ");
                                    break;
                                case ErrorCode.InvoiceTemplateNotValidInDeclaration:
                                    Common.ShowMessage("Tờ khai đăng ký/thay đổi đã được Cơ quan thuế chấp nhận không tồn tại");
                                    break;
                                case ErrorCode.InvoiceNumberNotCotinuous:
                                    Common.ShowMessage("Số hóa đơn không liên tục");
                                    break;
                                case ErrorCode.InvalidInvNo:
                                    Common.ShowMessage("Số hóa đơn không hợp lệ");
                                    break;
                                case ErrorCode.InvalidInvoiceDate:
                                    Common.ShowMessage("Ngày hóa đơn không hợp lệ");
                                    break;
                                case ErrorCode.TaxRateInfo_:
                                    Common.ShowMessage("Tên loại thuế suất trong Bảng tổng hợp thuế suất của hóa đơn có dữ liệu không hợp lệ");
                                    break;
                                case ErrorCode.InvalidTaxCode:
                                    Common.ShowMessage("Mã số thuế người bán không giống MST kết nối");
                                    break;

                                default:
                                    Common.ShowMessage(pubResult[0].ErrorCode);
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Common.ShowMessage("Phát hành thất bại: " + pubResult[0].ErrorCode);
                    }
                }
                else
                {
                    Common.ShowMessage("Phát hành thất bại: " + PublishInvoiceResult.ErrorCode);
                }
            }
            catch (Exception ex)
            {
                Common.ShowException(ex);
            }
            finally
            { this.Cursor = Cursors.Default; }
        }

        /// <summary>
        /// Xem hóa đơn chưa phát hành
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                var GetLinkResult = InvoicePublishingObject.GetLinkViewInvoiceUnPublish(BuildOriginalInvoiceData());
                if (GetLinkResult.Success && !string.IsNullOrEmpty(GetLinkResult.LinkViewInvoice))
                {
                    System.Diagnostics.Process.Start(GetLinkResult.LinkViewInvoice);
                }
                else
                {
                    Common.ShowMessage("không lấy đươc link xem trước, mã lỗi: " + GetLinkResult.ErrorCode);
                }
            }
            catch (Exception ex)
            {
                Common.ShowException(ex);
            }
            finally
            { this.Cursor = Cursors.Default; }
        }

        #region Event Form

        private void CheckVisiblePanel()
        {
            pnlSignFile.Visible = rbSignFile.Checked;
            pnlSignServer.Visible = rbSignServer.Checked;
        }

        /// <summary>
        /// Check ký trực tiếp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbSignDirect_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CheckVisiblePanel();
            }
            catch (Exception ex)
            {

                Common.ShowException(ex);
            }
        }

        /// <summary>
        /// Ký Server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbSignServer_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CheckVisiblePanel();
            }
            catch (Exception ex)
            {
                Common.ShowException(ex);
            }
        }

        private void rbHSM_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Common.ShowException(ex);
            }
        }

        private void rbSignFile_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CheckVisiblePanel();
            }
            catch (Exception ex)
            {
                Common.ShowException(ex);
            }
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbNormal.Checked)
                {
                    lblNumberOrg.Visible = false;
                    txtNumberOrg.Visible = false;
                    lblOrgDate.Visible = false;
                    dteOrgDate.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Common.ShowException(ex);
            }
        }

        private void rbAdjust_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbAdjust.Checked)
                {
                    lblNumberOrg.Visible = true;
                    txtNumberOrg.Visible = true;
                    lblOrgDate.Visible = true;
                    dteOrgDate.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Common.ShowException(ex);
            }
        }

        private void rbReplace_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbReplace.Checked)
                {
                    lblNumberOrg.Visible = true;
                    txtNumberOrg.Visible = true;
                    lblOrgDate.Visible = true;
                    dteOrgDate.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Common.ShowException(ex);
            }
        }

        #endregion
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
