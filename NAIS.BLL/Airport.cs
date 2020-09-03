using System;
using System.Data;
using System.Collections.Generic;
using NAIS.Model;
using NAIS.Lib;
using System.Data.SqlClient;

namespace NAIS.BLL
{
	/// <summary>
	/// AIRPORT
	/// </summary>
	public partial class AIRPORT
	{
		private readonly NAIS.DAL.AIRPORT dal=new NAIS.DAL.AIRPORT();
		public AIRPORT()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal AIRPORT_ID)
		{
			return dal.Exists(AIRPORT_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(NAIS.Model.AIRPORT model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(NAIS.Model.AIRPORT model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(decimal AIRPORT_ID)
		{
			
			return dal.Delete(AIRPORT_ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string AIRPORT_IDlist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(AIRPORT_IDlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public NAIS.Model.AIRPORT GetModel(decimal AIRPORT_ID)
		{
			
			return dal.GetModel((sqlStr)=> {
                sqlStr.Append(" where AIRPORT_ID=@AIRPORT_ID ");
                SqlParameter[] parameters = {
                        new SqlParameter("@AIRPORT_ID", SqlDbType.Decimal,9)            };
                parameters[0].Value = AIRPORT_ID;
                return parameters;
            });
		}

        /// <summary>
        /// 得到一个对象实体--------重载+1--------参数为机场名
        /// </summary>
        public NAIS.Model.AIRPORT GetModel(string AIRPORT_NAME)
        {

            return dal.GetModel((sqlStr) => {
                sqlStr.Append(" where NAME like '%'+@NAME+'%' ");
                SqlParameter[] parameters = {
                        new SqlParameter("@NAME", SqlDbType.NVarChar,9)            };
                parameters[0].Value = AIRPORT_NAME;
                return parameters;
            });
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
  //      public NAIS.Model.AIRPORT GetModelByCache(decimal AIRPORT_ID)
		//{
			
		//	string CacheKey = "AIRPORTModel-" + AIRPORT_ID;
		//	object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
		//	if (objModel == null)
		//	{
		//		try
		//		{
		//			objModel = dal.GetModel(AIRPORT_ID);
		//			if (objModel != null)
		//			{
		//				int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
		//				Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
		//			}
		//		}
		//		catch{}
		//	}
		//	return (NAIS.Model.AIRPORT)objModel;
		//}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<NAIS.Model.AIRPORT> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<NAIS.Model.AIRPORT> DataTableToList(DataTable dt)
		{
			List<NAIS.Model.AIRPORT> modelList = new List<NAIS.Model.AIRPORT>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
                NAIS.Model.AIRPORT model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod
        public static void Convert_Lng_Lat_Of_Model(List<NAIS.Model.AIRPORT> list)
        {
            list.ForEach(p =>
            {
                p.LONGITUDE = Longitude.Parse(p.LONGITUDE.ToString(),p.EAST_OR_WEST).ToString();
                p.LATITUDE = Latitude.Parse(p.LATITUDE.ToString(),p.SOUTH_OR_NORTH).ToString();
            });
        }
        public static void Convert_Lng_Lat_Of_Model(NAIS.Model.AIRPORT aIRPORT)
        {
                aIRPORT.LONGITUDE = Longitude.Parse(aIRPORT.LONGITUDE.ToString(), aIRPORT.EAST_OR_WEST).ToString();
                aIRPORT.LATITUDE = Latitude.Parse(aIRPORT.LATITUDE.ToString(), aIRPORT.SOUTH_OR_NORTH).ToString();
        }
        #endregion  ExtensionMethod
    }
}

