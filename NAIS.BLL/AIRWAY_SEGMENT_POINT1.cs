using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using NAIS.Model;
using System.Linq;

namespace NAIS.BLL
{
	/// <summary>
	/// AIRWAY_SEGMENT_POINT1
	/// </summary>
	public partial class AIRWAY_SEGMENT_POINT1
	{
		private readonly NAIS.DAL.AIRWAY_SEGMENT_POINT1 dal=new NAIS.DAL.AIRWAY_SEGMENT_POINT1();
		public AIRWAY_SEGMENT_POINT1()
		{}
		#region  BasicMethod

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(NAIS.Model.AIRWAY_SEGMENT_POINT1 model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(NAIS.Model.AIRWAY_SEGMENT_POINT1 model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.Delete();
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public NAIS.Model.AIRWAY_SEGMENT_POINT1 GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.GetModel();
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public NAIS.Model.AIRWAY_SEGMENT_POINT1 GetModelByCache()
		{
			//该表无主键信息，请自定义主键/条件字段
			string CacheKey = "AIRWAY_SEGMENT_POINT1Model-" ;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel();
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (NAIS.Model.AIRWAY_SEGMENT_POINT1)objModel;
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
		public List<NAIS.Model.AIRWAY_SEGMENT_POINT1> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<NAIS.Model.AIRWAY_SEGMENT_POINT1> DataTableToList(DataTable dt)
		{
			List<NAIS.Model.AIRWAY_SEGMENT_POINT1> modelList = new List<NAIS.Model.AIRWAY_SEGMENT_POINT1>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				NAIS.Model.AIRWAY_SEGMENT_POINT1 model;
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
        public void GetSegment(List<Model.AIRWAY_SEGMENT_POINT1> list, List<Model.AIRWAY_SEGMENT> 
            aIRWAY_SEGMENTs)
        {
            list.ForEach(p =>
            {
                p.Airway_segment = aIRWAY_SEGMENTs.Where(q => (q.Point1.AIRWAY_POINT_ID == p.AIRWAY_POINT_ID)
&& (q.Point2.AIRWAY_POINT_ID == p.ARIWAY_POINT1_ID)).First();
                if (p.Airway_segment.ToString() == null)
                {
                    throw new ArgumentNullException(p.AIRWAY_ID.ToString(),"error");
                }
            });
        }
        public void GetSegment(Model.AIRWAY_SEGMENT_POINT1 p, List<Model.AIRWAY_SEGMENT> aIRWAY_SEGMENTs)
        {
            p.Airway_segment = aIRWAY_SEGMENTs.Where(q => (q.Point1.AIRWAY_POINT_ID == p.AIRWAY_POINT_ID)
&& (q.Point2.AIRWAY_POINT_ID == p.ARIWAY_POINT1_ID)).First();
        }
        #endregion  ExtensionMethod
    }
}

