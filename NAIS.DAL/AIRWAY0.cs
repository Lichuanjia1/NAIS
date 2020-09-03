using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace NAIS.DAL
{
	/// <summary>
	/// 数据访问类:AIRWAY0
	/// </summary>
	public partial class AIRWAY0
	{
		public AIRWAY0()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("AIRWAY_ID", "AIRWAY0"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int AIRWAY_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from AIRWAY0");
			strSql.Append(" where AIRWAY_ID=@AIRWAY_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@AIRWAY_ID", SqlDbType.Int,4)			};
			parameters[0].Value = AIRWAY_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(NAIS.Model.AIRWAY0 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into AIRWAY0(");
			strSql.Append("AIRWAY_ID,AIRWAY_TYPE_ID,AF_AIRWAY_NO,AIRWAY_IDENTIFIER,AIRWAY_NAME,AIRWAY_AREA_ID,KILOMETER_DISTANCE,SEAMILE_DISTANCE,MIN_ALTITUDE,KILOMETER_DISTANCE0,SEAMILE_DISTANCE0,MIN_ALTITUDE0,ACCOUNT,UPDATE_TIME,AIRWAY_NOTE,IS_MODIFIED,CREATE_TIME,AIRWAY_RNP,IS_CONFIRMED)");
			strSql.Append(" values (");
			strSql.Append("@AIRWAY_ID,@AIRWAY_TYPE_ID,@AF_AIRWAY_NO,@AIRWAY_IDENTIFIER,@AIRWAY_NAME,@AIRWAY_AREA_ID,@KILOMETER_DISTANCE,@SEAMILE_DISTANCE,@MIN_ALTITUDE,@KILOMETER_DISTANCE0,@SEAMILE_DISTANCE0,@MIN_ALTITUDE0,@ACCOUNT,@UPDATE_TIME,@AIRWAY_NOTE,@IS_MODIFIED,@CREATE_TIME,@AIRWAY_RNP,@IS_CONFIRMED)");
			SqlParameter[] parameters = {
					new SqlParameter("@AIRWAY_ID", SqlDbType.Int,4),
					new SqlParameter("@AIRWAY_TYPE_ID", SqlDbType.Int,4),
					new SqlParameter("@AF_AIRWAY_NO", SqlDbType.Int,4),
					new SqlParameter("@AIRWAY_IDENTIFIER", SqlDbType.NVarChar,6),
					new SqlParameter("@AIRWAY_NAME", SqlDbType.NVarChar,40),
					new SqlParameter("@AIRWAY_AREA_ID", SqlDbType.Int,4),
					new SqlParameter("@KILOMETER_DISTANCE", SqlDbType.Int,4),
					new SqlParameter("@SEAMILE_DISTANCE", SqlDbType.Int,4),
					new SqlParameter("@MIN_ALTITUDE", SqlDbType.Int,4),
					new SqlParameter("@KILOMETER_DISTANCE0", SqlDbType.Int,4),
					new SqlParameter("@SEAMILE_DISTANCE0", SqlDbType.Int,4),
					new SqlParameter("@MIN_ALTITUDE0", SqlDbType.Int,4),
					new SqlParameter("@ACCOUNT", SqlDbType.NVarChar,50),
					new SqlParameter("@UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@AIRWAY_NOTE", SqlDbType.NVarChar,100),
					new SqlParameter("@IS_MODIFIED", SqlDbType.Int,4),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@AIRWAY_RNP", SqlDbType.NVarChar,100),
					new SqlParameter("@IS_CONFIRMED", SqlDbType.Int,4)};
			parameters[0].Value = model.AIRWAY_ID;
			parameters[1].Value = model.AIRWAY_TYPE_ID;
			parameters[2].Value = model.AF_AIRWAY_NO;
			parameters[3].Value = model.AIRWAY_IDENTIFIER;
			parameters[4].Value = model.AIRWAY_NAME;
			parameters[5].Value = model.AIRWAY_AREA_ID;
			parameters[6].Value = model.KILOMETER_DISTANCE;
			parameters[7].Value = model.SEAMILE_DISTANCE;
			parameters[8].Value = model.MIN_ALTITUDE;
			parameters[9].Value = model.KILOMETER_DISTANCE0;
			parameters[10].Value = model.SEAMILE_DISTANCE0;
			parameters[11].Value = model.MIN_ALTITUDE0;
			parameters[12].Value = model.ACCOUNT;
			parameters[13].Value = model.UPDATE_TIME;
			parameters[14].Value = model.AIRWAY_NOTE;
			parameters[15].Value = model.IS_MODIFIED;
			parameters[16].Value = model.CREATE_TIME;
			parameters[17].Value = model.AIRWAY_RNP;
			parameters[18].Value = model.IS_CONFIRMED;

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
		public bool Update(NAIS.Model.AIRWAY0 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update AIRWAY0 set ");
			strSql.Append("AIRWAY_TYPE_ID=@AIRWAY_TYPE_ID,");
			strSql.Append("AF_AIRWAY_NO=@AF_AIRWAY_NO,");
			strSql.Append("AIRWAY_IDENTIFIER=@AIRWAY_IDENTIFIER,");
			strSql.Append("AIRWAY_NAME=@AIRWAY_NAME,");
			strSql.Append("AIRWAY_AREA_ID=@AIRWAY_AREA_ID,");
			strSql.Append("KILOMETER_DISTANCE=@KILOMETER_DISTANCE,");
			strSql.Append("SEAMILE_DISTANCE=@SEAMILE_DISTANCE,");
			strSql.Append("MIN_ALTITUDE=@MIN_ALTITUDE,");
			strSql.Append("KILOMETER_DISTANCE0=@KILOMETER_DISTANCE0,");
			strSql.Append("SEAMILE_DISTANCE0=@SEAMILE_DISTANCE0,");
			strSql.Append("MIN_ALTITUDE0=@MIN_ALTITUDE0,");
			strSql.Append("ACCOUNT=@ACCOUNT,");
			strSql.Append("UPDATE_TIME=@UPDATE_TIME,");
			strSql.Append("AIRWAY_NOTE=@AIRWAY_NOTE,");
			strSql.Append("IS_MODIFIED=@IS_MODIFIED,");
			strSql.Append("CREATE_TIME=@CREATE_TIME,");
			strSql.Append("AIRWAY_RNP=@AIRWAY_RNP,");
			strSql.Append("IS_CONFIRMED=@IS_CONFIRMED");
			strSql.Append(" where AIRWAY_ID=@AIRWAY_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@AIRWAY_TYPE_ID", SqlDbType.Int,4),
					new SqlParameter("@AF_AIRWAY_NO", SqlDbType.Int,4),
					new SqlParameter("@AIRWAY_IDENTIFIER", SqlDbType.NVarChar,6),
					new SqlParameter("@AIRWAY_NAME", SqlDbType.NVarChar,40),
					new SqlParameter("@AIRWAY_AREA_ID", SqlDbType.Int,4),
					new SqlParameter("@KILOMETER_DISTANCE", SqlDbType.Int,4),
					new SqlParameter("@SEAMILE_DISTANCE", SqlDbType.Int,4),
					new SqlParameter("@MIN_ALTITUDE", SqlDbType.Int,4),
					new SqlParameter("@KILOMETER_DISTANCE0", SqlDbType.Int,4),
					new SqlParameter("@SEAMILE_DISTANCE0", SqlDbType.Int,4),
					new SqlParameter("@MIN_ALTITUDE0", SqlDbType.Int,4),
					new SqlParameter("@ACCOUNT", SqlDbType.NVarChar,50),
					new SqlParameter("@UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@AIRWAY_NOTE", SqlDbType.NVarChar,100),
					new SqlParameter("@IS_MODIFIED", SqlDbType.Int,4),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@AIRWAY_RNP", SqlDbType.NVarChar,100),
					new SqlParameter("@IS_CONFIRMED", SqlDbType.Int,4),
					new SqlParameter("@AIRWAY_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.AIRWAY_TYPE_ID;
			parameters[1].Value = model.AF_AIRWAY_NO;
			parameters[2].Value = model.AIRWAY_IDENTIFIER;
			parameters[3].Value = model.AIRWAY_NAME;
			parameters[4].Value = model.AIRWAY_AREA_ID;
			parameters[5].Value = model.KILOMETER_DISTANCE;
			parameters[6].Value = model.SEAMILE_DISTANCE;
			parameters[7].Value = model.MIN_ALTITUDE;
			parameters[8].Value = model.KILOMETER_DISTANCE0;
			parameters[9].Value = model.SEAMILE_DISTANCE0;
			parameters[10].Value = model.MIN_ALTITUDE0;
			parameters[11].Value = model.ACCOUNT;
			parameters[12].Value = model.UPDATE_TIME;
			parameters[13].Value = model.AIRWAY_NOTE;
			parameters[14].Value = model.IS_MODIFIED;
			parameters[15].Value = model.CREATE_TIME;
			parameters[16].Value = model.AIRWAY_RNP;
			parameters[17].Value = model.IS_CONFIRMED;
			parameters[18].Value = model.AIRWAY_ID;

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
		public bool Delete(int AIRWAY_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from AIRWAY0 ");
			strSql.Append(" where AIRWAY_ID=@AIRWAY_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@AIRWAY_ID", SqlDbType.Int,4)			};
			parameters[0].Value = AIRWAY_ID;

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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string AIRWAY_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from AIRWAY0 ");
			strSql.Append(" where AIRWAY_ID in ("+AIRWAY_IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public NAIS.Model.AIRWAY0 GetModel(int AIRWAY_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 AIRWAY_ID,AIRWAY_TYPE_ID,AF_AIRWAY_NO,AIRWAY_IDENTIFIER,AIRWAY_NAME,AIRWAY_AREA_ID,KILOMETER_DISTANCE,SEAMILE_DISTANCE,MIN_ALTITUDE,KILOMETER_DISTANCE0,SEAMILE_DISTANCE0,MIN_ALTITUDE0,ACCOUNT,UPDATE_TIME,AIRWAY_NOTE,IS_MODIFIED,CREATE_TIME,AIRWAY_RNP,IS_CONFIRMED from AIRWAY0 ");
			strSql.Append(" where AIRWAY_ID=@AIRWAY_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@AIRWAY_ID", SqlDbType.Int,4)			};
			parameters[0].Value = AIRWAY_ID;

			NAIS.Model.AIRWAY0 model=new NAIS.Model.AIRWAY0();
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
		public NAIS.Model.AIRWAY0 DataRowToModel(DataRow row)
		{
			NAIS.Model.AIRWAY0 model=new NAIS.Model.AIRWAY0();
			if (row != null)
			{
				if(row["AIRWAY_ID"]!=null && row["AIRWAY_ID"].ToString()!="")
				{
					model.AIRWAY_ID=int.Parse(row["AIRWAY_ID"].ToString());
				}
				if(row["AIRWAY_TYPE_ID"]!=null && row["AIRWAY_TYPE_ID"].ToString()!="")
				{
					model.AIRWAY_TYPE_ID=int.Parse(row["AIRWAY_TYPE_ID"].ToString());
				}
				if(row["AF_AIRWAY_NO"]!=null && row["AF_AIRWAY_NO"].ToString()!="")
				{
					model.AF_AIRWAY_NO=int.Parse(row["AF_AIRWAY_NO"].ToString());
				}
				if(row["AIRWAY_IDENTIFIER"]!=null)
				{
					model.AIRWAY_IDENTIFIER=row["AIRWAY_IDENTIFIER"].ToString();
				}
				if(row["AIRWAY_NAME"]!=null)
				{
					model.AIRWAY_NAME=row["AIRWAY_NAME"].ToString();
				}
				if(row["AIRWAY_AREA_ID"]!=null && row["AIRWAY_AREA_ID"].ToString()!="")
				{
					model.AIRWAY_AREA_ID=int.Parse(row["AIRWAY_AREA_ID"].ToString());
				}
				if(row["KILOMETER_DISTANCE"]!=null && row["KILOMETER_DISTANCE"].ToString()!="")
				{
					model.KILOMETER_DISTANCE=int.Parse(row["KILOMETER_DISTANCE"].ToString());
				}
				if(row["SEAMILE_DISTANCE"]!=null && row["SEAMILE_DISTANCE"].ToString()!="")
				{
					model.SEAMILE_DISTANCE=int.Parse(row["SEAMILE_DISTANCE"].ToString());
				}
				if(row["MIN_ALTITUDE"]!=null && row["MIN_ALTITUDE"].ToString()!="")
				{
					model.MIN_ALTITUDE=int.Parse(row["MIN_ALTITUDE"].ToString());
				}
				if(row["KILOMETER_DISTANCE0"]!=null && row["KILOMETER_DISTANCE0"].ToString()!="")
				{
					model.KILOMETER_DISTANCE0=int.Parse(row["KILOMETER_DISTANCE0"].ToString());
				}
				if(row["SEAMILE_DISTANCE0"]!=null && row["SEAMILE_DISTANCE0"].ToString()!="")
				{
					model.SEAMILE_DISTANCE0=int.Parse(row["SEAMILE_DISTANCE0"].ToString());
				}
				if(row["MIN_ALTITUDE0"]!=null && row["MIN_ALTITUDE0"].ToString()!="")
				{
					model.MIN_ALTITUDE0=int.Parse(row["MIN_ALTITUDE0"].ToString());
				}
				if(row["ACCOUNT"]!=null)
				{
					model.ACCOUNT=row["ACCOUNT"].ToString();
				}
				if(row["UPDATE_TIME"]!=null && row["UPDATE_TIME"].ToString()!="")
				{
					model.UPDATE_TIME=DateTime.Parse(row["UPDATE_TIME"].ToString());
				}
				if(row["AIRWAY_NOTE"]!=null)
				{
					model.AIRWAY_NOTE=row["AIRWAY_NOTE"].ToString();
				}
				if(row["IS_MODIFIED"]!=null && row["IS_MODIFIED"].ToString()!="")
				{
					model.IS_MODIFIED=int.Parse(row["IS_MODIFIED"].ToString());
				}
				if(row["CREATE_TIME"]!=null && row["CREATE_TIME"].ToString()!="")
				{
					model.CREATE_TIME=DateTime.Parse(row["CREATE_TIME"].ToString());
				}
				if(row["AIRWAY_RNP"]!=null)
				{
					model.AIRWAY_RNP=row["AIRWAY_RNP"].ToString();
				}
				if(row["IS_CONFIRMED"]!=null && row["IS_CONFIRMED"].ToString()!="")
				{
					model.IS_CONFIRMED=int.Parse(row["IS_CONFIRMED"].ToString());
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
			strSql.Append("select AIRWAY_ID,AIRWAY_TYPE_ID,AF_AIRWAY_NO,AIRWAY_IDENTIFIER,AIRWAY_NAME,AIRWAY_AREA_ID,KILOMETER_DISTANCE,SEAMILE_DISTANCE,MIN_ALTITUDE,KILOMETER_DISTANCE0,SEAMILE_DISTANCE0,MIN_ALTITUDE0,ACCOUNT,UPDATE_TIME,AIRWAY_NOTE,IS_MODIFIED,CREATE_TIME,AIRWAY_RNP,IS_CONFIRMED ");
			strSql.Append(" FROM AIRWAY0 ");
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
			strSql.Append(" AIRWAY_ID,AIRWAY_TYPE_ID,AF_AIRWAY_NO,AIRWAY_IDENTIFIER,AIRWAY_NAME,AIRWAY_AREA_ID,KILOMETER_DISTANCE,SEAMILE_DISTANCE,MIN_ALTITUDE,KILOMETER_DISTANCE0,SEAMILE_DISTANCE0,MIN_ALTITUDE0,ACCOUNT,UPDATE_TIME,AIRWAY_NOTE,IS_MODIFIED,CREATE_TIME,AIRWAY_RNP,IS_CONFIRMED ");
			strSql.Append(" FROM AIRWAY0 ");
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
			strSql.Append("select count(1) FROM AIRWAY0 ");
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
				strSql.Append("order by T.AIRWAY_ID desc");
			}
			strSql.Append(")AS Row, T.*  from AIRWAY0 T ");
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
			parameters[0].Value = "AIRWAY0";
			parameters[1].Value = "AIRWAY_ID";
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

