using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using NAIS.Model;
using NAIS.Lib;
namespace NAIS.BLL
{
	/// <summary>
	/// AIRWAY_POINT0
	/// </summary>
	public partial class AIRWAY_POINT0
	{
		private readonly NAIS.DAL.AIRWAY_POINT0 dal=new NAIS.DAL.AIRWAY_POINT0();
		public AIRWAY_POINT0()
		{}
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int AIRWAY_POINT_ID)
		{
			return dal.Exists(AIRWAY_POINT_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(NAIS.Model.AIRWAY_POINT0 model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(NAIS.Model.AIRWAY_POINT0 model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int AIRWAY_POINT_ID)
		{
			
			return dal.Delete(AIRWAY_POINT_ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string AIRWAY_POINT_IDlist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(AIRWAY_POINT_IDlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public NAIS.Model.AIRWAY_POINT0 GetModel(int AIRWAY_POINT_ID)
		{
			
			return dal.GetModel(AIRWAY_POINT_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public NAIS.Model.AIRWAY_POINT0 GetModelByCache(int AIRWAY_POINT_ID)
		{
			
			string CacheKey = "AIRWAY_POINT0Model-" + AIRWAY_POINT_ID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(AIRWAY_POINT_ID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (NAIS.Model.AIRWAY_POINT0)objModel;
		}

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
		public List<NAIS.Model.AIRWAY_POINT0> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<NAIS.Model.AIRWAY_POINT0> DataTableToList(DataTable dt)
		{
			List<NAIS.Model.AIRWAY_POINT0> modelList = new List<NAIS.Model.AIRWAY_POINT0>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				NAIS.Model.AIRWAY_POINT0 model;
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
        public static void Convert_Lng_Lat_Of_Model(List<NAIS.Model.AIRWAY_POINT0> list)
        {
            list.ForEach(p =>
            {
                /*
                 *方法体
                 */
                p.LATITUDE = Latitude.Parse(p.LATITUDE);
                p.LONGITUDE = Longitude.Parse(p.LONGITUDE);
            });
        }
        public static void Convert_Lng_Lat_Of_Model(NAIS.Model.AIRWAY_POINT0 p)
        {
                /*
                 *方法体
                 */
                p.LATITUDE = Latitude.Parse(p.LATITUDE);
                p.LONGITUDE = Longitude.Parse(p.LONGITUDE);
        }
        public static void GetPicture(List<NAIS.Model.AIRWAY_POINT0> list)
        {
            list.ForEach(p =>
            {
                if (Pictures.pictures[p.AIRWAY_POINT_TYPE_ID-1] != null)
                {
                    p.Url = Pictures.pictures[p.AIRWAY_POINT_TYPE_ID - 1];
                }
                else
                {
                    p.Url = "reportPoint1.png";
                }
            });
        }
        #endregion  ExtensionMethod
    }
}

