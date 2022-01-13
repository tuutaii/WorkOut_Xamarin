using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web_API_WorkOut_App.Controllers
{
    public class ServiceController : ApiController
    {

        //GET API/SERVICECONTROLLER/HELLOWEBAPI

        [Route("api/ServiceController/HellwordAPI")]
        [HttpGet]
        public IHttpActionResult HelloWord()
        {
            return Ok("Welcome to web api");
        }

        //GET API/SERVICECONTROLLER/GETALLBAITAP
        [Route("api/ServiceController/GetAllBaiTap")]
        [HttpGet]
        public IHttpActionResult GetAllBaiTap()
        {
            try
            {
                DataTable result = Database.Database.ReadTable("PROC_GetAllBaiTap");
                return Ok(result);

            }
            catch 
            {
                return NotFound();
            }
        }


        //GET API/SERVICECONTROLLER/GETALLDANHMUC
        [Route("api/ServiceController/GetAllDanhMuc")]
        [HttpGet]
        public IHttpActionResult GetAllDanhMuc()
        {
            try
            {
                DataTable result = Database.Database.ReadTable("PROC_GetAllDanhMuc");
                return Ok(result);

            }
            catch
            {
                return NotFound();
            }
        } 
        
        
        //GET API/SERVICECONTROLLER/GETALLDOITUONG
        [Route("api/ServiceController/GetAllDoiTuong")]
        [HttpGet]
        public IHttpActionResult GetAllDoiTuong()
        {
            try
            {
                DataTable result = Database.Database.ReadTable("PROC_GetAllDoiTuong");
                return Ok(result);

            }
            catch
            {
                return NotFound();
            }
        }


        //GET API/SERVICECONTROLLER/GETALLDOITUONG
        [Route("api/ServiceController/GetAllBaiTapbyID")]
        [HttpGet]
        public IHttpActionResult GetAllBaiTapbyID(int ID_baitap)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("ID_baitap", ID_baitap);

                DataTable result = Database.Database.ReadTable("PROC_GetBaiTapbyID", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }


        //GET API/SERVICECONTROLLER/GETALLBAITAPCHONGUOIMOI
        [Route("api/ServiceController/GetBaiTapChoNguoiMoi")]
        [HttpGet]
        public IHttpActionResult GetAllBaiTapChoNguoiMoi()
        {
            try
            {

                DataTable result = Database.Database.ReadTable("PROC_GetBaiTapChoNguoiMoi");
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }

        //GET API/SERVICECONTROLLER/GETALLBAITAPTRUNGBINH
        [Route("api/ServiceController/GetAllBaiTapTrungBinh")]
        [HttpGet]
        public IHttpActionResult GetAllBaiTapTrungBinh()
        {
            try
            {

                DataTable result = Database.Database.ReadTable("PROC_GetAllBaiTapTrungBinh");
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }

        //GET API/SERVICECONTROLLER/GETALLBAITAPNANGCAO
        [Route("api/ServiceController/GetAllBaiTapNangCao")]
        [HttpGet]
        public IHttpActionResult GetAllBaiTapNangCao()
        {
            try
            {

                DataTable result = Database.Database.ReadTable("PROC_GetAllBaiTapNangCao");
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }

        //GET API/SERVICECONTROLLER/GETALLBAITAPTAINHA
        [Route("api/ServiceController/GetBaiTapTaiNha")]
        [HttpGet]
        public IHttpActionResult GetAllBaiTapTaiNha()
        {
            try
            {

                DataTable result = Database.Database.ReadTable("PROC_GetBaiTapTaiNha");
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }


        //GET API/SERVICECONTROLLER/GETALLUSER
        [Route("api/ServiceController/GetAlluser")]
        [HttpGet]
        public IHttpActionResult GetAllUser()
        {
            try
            {

                DataTable result = Database.Database.ReadTable("PROC_GetAllUser");
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }

        //GET API/SERVICECONTROLLER/GETALLUSER
        [Route("api/ServiceController/GetBTPhanBung")]
        [HttpGet]
        public IHttpActionResult GetBTBung()
        {
            try
            {

                DataTable result = Database.Database.ReadTable("PROC_GetBaiTapBung");
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }

        //GET API/SERVICECONTROLLER/GETALLUSER
        [Route("api/ServiceController/GetBTPhanChan")]
        [HttpGet]
        public IHttpActionResult GetBTChan()
        {
            try
            {

                DataTable result = Database.Database.ReadTable("PROC_GetBaiTapChan");
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }

        //GET API/SERVICECONTROLLER/GETALLUSER
        [Route("api/ServiceController/GetBTTay")]
        [HttpGet]
        public IHttpActionResult GetBTTay()
        {
            try
            {

                DataTable result = Database.Database.ReadTable("PROC_GetBaiTapTay");
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }


        //GET API/SERVICECONTROLLER/GETALLUSER
        [Route("api/ServiceController/GetBTNguc")]
        [HttpGet]
        public IHttpActionResult GetBTNguc()
        {
            try
            {

                DataTable result = Database.Database.ReadTable("PROC_GetBaiTapNguc");
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }


        //GET API/SERVICECONTROLLER/GETHINHANH
        [Route("api/ServiceController/GetHinhAnh")]
        [HttpGet]
        public IHttpActionResult GetHinhAnh()
        {
            try
            {

                DataTable result = Database.Database.ReadTable("PROC_GetAllHinhAnh");
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }

        //GET API/SERVICECONTROLLER/GETALLUSER
        [Route("api/ServiceController/GetThoiLuongBaiTap")]
        [HttpGet]
        public IHttpActionResult GetThoiLuong(int ID_baitap)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("ID_baitap", ID_baitap);

                DataTable result = Database.Database.ReadTable("PROC_GetThoiLuongById", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }


    }
}
