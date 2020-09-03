using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using NAIS.DBUtility;//Please add references
using Maticsoft.DBUtility;

namespace NAIS.DAL
{
	/// <summary>
	/// 数据访问类:BUREAU
	/// </summary>
	public partial class BUREAU
	{
		public BUREAU()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(NAIS.Model.BUREAU model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BUREAU(");
			strSql.Append("BUREAU_ID,BUREAU_CODE,BUREAU_NAME,ADDRESS,TELEPHONE,CONTACT,WEBSITE,REMARK,BUREAU_SEQ,BUREAU_SHOW)");
			strSql.Append(" values (");
			strSql.Append("@BUREAU_ID,@BUREAU_CODE,@BUREAU_NAME,@ADDRESS,@TELEPHONE,@CONTACT,@WEBSITE,@REMARK,@BUREAU_SEQ,@BUREAU_SHOW)");
			SqlParameter[] parameters = {
					new SqlParameter("@BUREAU_ID", SqlDbType.Float,8),
					new SqlParameter("@BUREAU_CODE", SqlDbType.NVarChar,255),
					new SqlParameter("@BUREAU_NAME", SqlDbType.NVarChar,255),
					new SqlParameter("@ADDRESS", SqlDbType.NVarChar,255),
					new SqlParameter("@TELEPHONE", SqlDbType.NVarChar,255),
					new SqlParameter("@CONTACT", SqlDbType.NVarChar,255),
					new SqlParameter("@WEBSITE", SqlDbType.NVarChar,255),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,255),
					new SqlParameter("@BUREAU_SEQ", SqlDbType.Float,8),
					new SqlParameter("@BUREAU_SHOW", SqlDbType.Float,8)};
			parameters[0].Value = model.BUREAU_ID;
			parameters[1].Value = model.BUREAU_CODE;
			parameters[2].Value = model.BUREAU_NAME;
			parameters[3].Value = model.ADDRESS;
			parameters[4].Value = model.TELEPHONE;
			parameters[5].Value = model.CONTACT;
			parameters[6].Value = model.WEBSITE;
			parameters[7].Value = model.REMARK;
			parameters[8].Value = model.BUREAU_SEQ;
			parameters[9].Value = model.BUREAU_SHOW;

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
		public bool Update(NAIS.Model.BUREAU model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BUREAU set ");
			strSql.Append("BUREAU_ID=@BUREAU_ID,");
			strSql.Append("BUREAU_CODE=@BUREAU_CODE,");
			strSql.Append("BUREAU_NAME=@BUREAU_NAME,");
			strSql.Append("ADDRESS=@ADDRESS,");
			strSql.Append("TELEPHONE=@TELEPHONE,");
			strSql.Append("CONTACT=@CONTACT,");
			strSql.Append("WEBSITE=@WEBSITE,");
			strSql.Append("REMARK=@REMARK,");
			strSql.Append("BUREAU_SEQ=@BUREAU_SEQ,");
			strSql.Append("BUREAU_SHOW=@BUREAU_SHOW");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@BUREAU_ID", SqlDbType.Float,8),
					new SqlParameter("@BUREAU_CODE", SqlDbType.NVarChar,255),
					new SqlParameter("@BUREAU_NAME", SqlDbType.NVarChar,255),
					new SqlParameter("@ADDRESS", SqlDbType.NVarChar,255),
					new SqlParameter("@TELEPHONE", SqlDbType.NVarChar,255),
					new SqlParameter("@CONTACT", SqlDbType.NVarChar,255),
					new SqlParameter("@WEBSITE", SqlDbType.NVarChar,255),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,255),
					new SqlParameter("@BUREAU_SEQ", SqlDbType.Float,8),
					new SqlParameter("@BUREAU_SHOW", SqlDbType.Float,8)};
			parameters[0].Value = model.BUREAU_ID;
			parameters[1].Value = model.BUREAU_CODE;
			parameters[2].Value = model.BUREAU_NAME;
			parameters[3].Value = model.ADDRESS;
			parameters[4].Value = model.TELEPHONE;
			parameters[5].Value = model.CONTACT;
			parameters[6].Value = model.WEBSITE;
			parameters[7].Value = model.REMARK;
			parameters[8].Value = model.BUREAU_SEQ;
			parameters[9].Value = model.BUREAU_SHOW;

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
			strSql.Append("delete from BUREAU ");
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
		public NAIS.Model.BUREAU GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 BUREAU_ID,BUREAU_CODE,BUREAU_NAME,ADDRESS,TELEPHONE,CONTACT,WEBSITE,REMARK,BUREAU_SEQ,BUREAU_SHOW from BUREAU ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			NAIS.Model.BUREAU model=new NAIS.Model.BUREAU();
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
		public NAIS.Model.BUREAU DataRowToModel(DataRow row)
		{
			NAIS.Model.BUREAU model=new NAIS.Model.BUREAU();
			if (row != null)
			{
				if(row["BUREAU_ID"]!=null && row["BUREAU_ID"].ToString()!="")
				{
					model.BUREAU_ID=decimal.Parse(row["BUREAU_ID"].ToString());
				}
				if(row["BUREAU_CODE"]!=null)
				{
					model.BUREAU_CODE=row["BUREAU_CODE"].ToString();
				}
				if(row["BUREAU_NAME"]!=null)
				{
					model.BUREAU_NAME=row["BUREAU_NAME"].ToString();
				}
				if(row["ADDRESS"]!=null)
				{
					model.ADDRESS=row["ADDRESS"].ToString();
				}
				if(row["TELEPHONE"]!=null)
				{
					model.TELEPHONE=row["TELEPHONE"].ToString();
				}
				if(row["CONTACT"]!=null)
				{
					model.CONTACT=row["CONTACT"].ToString();
				}
				if(row["WEBSITE"]!=null)
				{
					model.WEBSITE=row["WEBSITE"].ToString();
				}
				if(row["REMARK"]!=null)
				{
					model.REMARK=row["REMARK"].ToString();
				}
				if(row["BUREAU_SEQ"]!=null && row["BUREAU_SEQ"].ToString()!="")
				{
					model.BUREAU_SEQ=decimal.Parse(row["BUREAU_SEQ"].ToString());
				}
				if(row["BUREAU_SHOW"]!=null && row["BUREAU_SHOW"].ToString()!="")
				{
					model.BUREAU_SHOW=decimal.Parse(row["BUREAU_SHOW"].ToString());
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
			strSql.Append("select BUREAU_ID,BUREAU_CODE,BUREAU_NAME,ADDRESS,TELEPHONE,CONTACT,WEBSITE,REMARK,BUREAU_SEQ,BUREAU_SHOW ");
			strSql.Append(" FROM BUREAU ");
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
			strSql.Append(" BUREAU_ID,BUREAU_CODE,BUREAU_NAME,ADDRESS,TELEPHONE,CONTACT,WEBSITE,REMARK,BUREAU_SEQ,BUREAU_SHOW ");
			strSql.Append(" FROM BUREAU ");
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
			strSql.Append("select count(1) FROM BUREAU ");
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
			strSql.Append(")AS Row, T.*  from BUREAU T ");
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
			parameters[0].Value = "BUREAU";
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

