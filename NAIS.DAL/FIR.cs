using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using NAIS.DBUtility;//Please add references
using Maticsoft.DBUtility;

namespace NAIS.DAL
{
	/// <summary>
	/// 数据访问类:FIR
	/// </summary>
	public partial class FIR
	{
		public FIR()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(NAIS.Model.FIR model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FIR(");
			strSql.Append("FIR_ID,FIR_CODE,NAME,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@FIR_ID,@FIR_CODE,@NAME,@REMARK)");
			SqlParameter[] parameters = {
					new SqlParameter("@FIR_ID", SqlDbType.Float,8),
					new SqlParameter("@FIR_CODE", SqlDbType.NVarChar,255),
					new SqlParameter("@NAME", SqlDbType.NVarChar,255),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,255)
            };
			parameters[0].Value = model.FIR_ID;
			parameters[1].Value = model.FIR_CODE;
			parameters[2].Value = model.NAME;
			parameters[3].Value = model.REMARK;

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
		public bool Update(NAIS.Model.FIR model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FIR set ");
			strSql.Append("FIR_ID=@FIR_ID,");
			strSql.Append("FIR_CODE=@FIR_CODE,");
			strSql.Append("NAME=@NAME,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@FIR_ID", SqlDbType.Float,8),
					new SqlParameter("@FIR_CODE", SqlDbType.NVarChar,255),
					new SqlParameter("@NAME", SqlDbType.NVarChar,255),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,255)};
			parameters[0].Value = model.FIR_ID;
			parameters[1].Value = model.FIR_CODE;
			parameters[2].Value = model.NAME;
			parameters[3].Value = model.REMARK;

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
			strSql.Append("delete from FIR ");
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
		public NAIS.Model.FIR GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 FIR_ID,FIR_CODE,NAME,REMARK from FIR ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			NAIS.Model.FIR model=new NAIS.Model.FIR();
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
		public NAIS.Model.FIR DataRowToModel(DataRow row)
		{
			NAIS.Model.FIR model=new NAIS.Model.FIR();
			if (row != null)
			{
				if(row["FIR_ID"]!=null && row["FIR_ID"].ToString()!="")
				{
					model.FIR_ID=decimal.Parse(row["FIR_ID"].ToString());
				}
				if(row["FIR_CODE"]!=null)
				{
					model.FIR_CODE=row["FIR_CODE"].ToString();
				}
				if(row["NAME"]!=null)
				{
					model.NAME=row["NAME"].ToString();
				}
				if(row["REMARK"]!=null)
				{
					model.REMARK=row["REMARK"].ToString();
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
			strSql.Append("select FIR_ID,FIR_CODE,NAME,REMARK ");
			strSql.Append(" FROM FIR ");
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
			strSql.Append(" FIR_ID,FIR_CODE,NAME,REMARK ");
			strSql.Append(" FROM FIR ");
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
			strSql.Append("select count(1) FROM FIR ");
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
			strSql.Append(")AS Row, T.*  from FIR T ");
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
			parameters[0].Value = "FIR";
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

