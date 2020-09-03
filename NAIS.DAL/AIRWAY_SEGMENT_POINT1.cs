using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace NAIS.DAL
{
	/// <summary>
	/// 数据访问类:AIRWAY_SEGMENT_POINT1
	/// </summary>
	public partial class AIRWAY_SEGMENT_POINT1
	{
		public AIRWAY_SEGMENT_POINT1()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(NAIS.Model.AIRWAY_SEGMENT_POINT1 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into AIRWAY_SEGMENT_POINT1(");
			strSql.Append("AIRWAY_SEGMENT_POINT_ID,AIRWAY_ID,AIRWAY_POINT_ID,AIRWAY_SEQ,ARIWAY_POINT1_ID,AIRWAY_SEQ1)");
			strSql.Append(" values (");
			strSql.Append("@AIRWAY_SEGMENT_POINT_ID,@AIRWAY_ID,@AIRWAY_POINT_ID,@AIRWAY_SEQ,@ARIWAY_POINT1_ID,@AIRWAY_SEQ1)");
			SqlParameter[] parameters = {
					new SqlParameter("@AIRWAY_SEGMENT_POINT_ID", SqlDbType.Int,4),
					new SqlParameter("@AIRWAY_ID", SqlDbType.Int,4),
					new SqlParameter("@AIRWAY_POINT_ID", SqlDbType.Int,4),
					new SqlParameter("@AIRWAY_SEQ", SqlDbType.Int,4),
					new SqlParameter("@ARIWAY_POINT1_ID", SqlDbType.Int,4),
					new SqlParameter("@AIRWAY_SEQ1", SqlDbType.Int,4)};
			parameters[0].Value = model.AIRWAY_SEGMENT_POINT_ID;
			parameters[1].Value = model.AIRWAY_ID;
			parameters[2].Value = model.AIRWAY_POINT_ID;
			parameters[3].Value = model.AIRWAY_SEQ;
			parameters[4].Value = model.ARIWAY_POINT1_ID;
			parameters[5].Value = model.AIRWAY_SEQ1;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(NAIS.Model.AIRWAY_SEGMENT_POINT1 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update AIRWAY_SEGMENT_POINT1 set ");
			strSql.Append("AIRWAY_SEGMENT_POINT_ID=@AIRWAY_SEGMENT_POINT_ID,");
			strSql.Append("AIRWAY_ID=@AIRWAY_ID,");
			strSql.Append("AIRWAY_POINT_ID=@AIRWAY_POINT_ID,");
			strSql.Append("AIRWAY_SEQ=@AIRWAY_SEQ,");
			strSql.Append("ARIWAY_POINT1_ID=@ARIWAY_POINT1_ID,");
			strSql.Append("AIRWAY_SEQ1=@AIRWAY_SEQ1");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@AIRWAY_SEGMENT_POINT_ID", SqlDbType.Int,4),
					new SqlParameter("@AIRWAY_ID", SqlDbType.Int,4),
					new SqlParameter("@AIRWAY_POINT_ID", SqlDbType.Int,4),
					new SqlParameter("@AIRWAY_SEQ", SqlDbType.Int,4),
					new SqlParameter("@ARIWAY_POINT1_ID", SqlDbType.Int,4),
					new SqlParameter("@AIRWAY_SEQ1", SqlDbType.Int,4)};
			parameters[0].Value = model.AIRWAY_SEGMENT_POINT_ID;
			parameters[1].Value = model.AIRWAY_ID;
			parameters[2].Value = model.AIRWAY_POINT_ID;
			parameters[3].Value = model.AIRWAY_SEQ;
			parameters[4].Value = model.ARIWAY_POINT1_ID;
			parameters[5].Value = model.AIRWAY_SEQ1;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from AIRWAY_SEGMENT_POINT1 ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public NAIS.Model.AIRWAY_SEGMENT_POINT1 GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 AIRWAY_SEGMENT_POINT_ID,AIRWAY_ID,AIRWAY_POINT_ID,AIRWAY_SEQ,ARIWAY_POINT1_ID,AIRWAY_SEQ1 from AIRWAY_SEGMENT_POINT1 ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			NAIS.Model.AIRWAY_SEGMENT_POINT1 model=new NAIS.Model.AIRWAY_SEGMENT_POINT1();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public NAIS.Model.AIRWAY_SEGMENT_POINT1 DataRowToModel(DataRow row)
		{
			NAIS.Model.AIRWAY_SEGMENT_POINT1 model=new NAIS.Model.AIRWAY_SEGMENT_POINT1();
			if (row != null)
			{
				if(row["AIRWAY_SEGMENT_POINT_ID"]!=null && row["AIRWAY_SEGMENT_POINT_ID"].ToString()!="")
				{
					model.AIRWAY_SEGMENT_POINT_ID=int.Parse(row["AIRWAY_SEGMENT_POINT_ID"].ToString());
				}
				if(row["AIRWAY_ID"]!=null && row["AIRWAY_ID"].ToString()!="")
				{
					model.AIRWAY_ID=int.Parse(row["AIRWAY_ID"].ToString());
				}
				if(row["AIRWAY_POINT_ID"]!=null && row["AIRWAY_POINT_ID"].ToString()!="")
				{
					model.AIRWAY_POINT_ID=int.Parse(row["AIRWAY_POINT_ID"].ToString());
				}
				if(row["AIRWAY_SEQ"]!=null && row["AIRWAY_SEQ"].ToString()!="")
				{
					model.AIRWAY_SEQ=int.Parse(row["AIRWAY_SEQ"].ToString());
				}
				if(row["ARIWAY_POINT1_ID"]!=null && row["ARIWAY_POINT1_ID"].ToString()!="")
				{
					model.ARIWAY_POINT1_ID=int.Parse(row["ARIWAY_POINT1_ID"].ToString());
				}
				if(row["AIRWAY_SEQ1"]!=null && row["AIRWAY_SEQ1"].ToString()!="")
				{
					model.AIRWAY_SEQ1=int.Parse(row["AIRWAY_SEQ1"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select AIRWAY_SEGMENT_POINT_ID,AIRWAY_ID,AIRWAY_POINT_ID,AIRWAY_SEQ,ARIWAY_POINT1_ID,AIRWAY_SEQ1 ");
			strSql.Append(" FROM AIRWAY_SEGMENT_POINT1 ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" AIRWAY_SEGMENT_POINT_ID,AIRWAY_ID,AIRWAY_POINT_ID,AIRWAY_SEQ,ARIWAY_POINT1_ID,AIRWAY_SEQ1 ");
			strSql.Append(" FROM AIRWAY_SEGMENT_POINT1 ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM AIRWAY_SEGMENT_POINT1 ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T. desc");
			}
			strSql.Append(")AS Row, T.*  from AIRWAY_SEGMENT_POINT1 T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "AIRWAY_SEGMENT_POINT1";
			parameters[1].Value = "";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

