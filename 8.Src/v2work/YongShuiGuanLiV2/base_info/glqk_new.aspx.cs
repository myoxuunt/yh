using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace YongShuiGuanLiV2.base_info
{
    public partial class glqk_new : System.Web.UI.Page
    {
        YongShuiGuanLiDBI.login_data lo = new YongShuiGuanLiDBI.login_data();
        string address = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void UploadFile(object sender, EventArgs E)
        {

            //检查上传文件不为空
            if (myFile.PostedFile != null)
            {
                string nam = myFile.PostedFile.FileName;
                //取得文件名(抱括路径)里最后一个"."的索引
                int i = nam.LastIndexOf(".");
                //取得文件扩展名
                string newext = nam.Substring(i);
                //这里我自动根据日期和文件大小不同为文件命名,确保文件名不重复
                DateTime now = DateTime.Now;
                string newname = now.DayOfYear.ToString() + myFile.PostedFile.ContentLength.ToString();

                //保存文件到你所要的目录,这里是IIS根目录下的uploadfiles目录
                //注意: 我这里用Server.MapPath()取当前文件的绝对目录.在asp.net里"\"必须用"\\"代替
                myFile.PostedFile.SaveAs(Server.MapPath("..\\UpLoadFiles\\" + newname + newext));
                //				myFile.PostedFile.SaveAs("\\\\"+address+"\\FunshionMedia");

                //得到这个文件的相关属性:文件名,文件类型,文件大小
                fname.Text = myFile.PostedFile.FileName;
                fenc.Text = myFile.PostedFile.ContentType;
                fsize.Text = myFile.PostedFile.ContentLength.ToString();
                address = Server.MapPath("..\\UpLoadFiles\\" + newname + newext);
                //address="../W_client/UpLoadFiles/"+newname+newext;
                Image1.ImageUrl = address;
            }
        }

        protected void upload_Click(object sender, EventArgs e)
        {
            UploadFile(sender, e);
            lo.glqktj_new(this.year.Text, address, this.remark.Text, System.DateTime.Today.ToShortDateString());
        }
    }
}
