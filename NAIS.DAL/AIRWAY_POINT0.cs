using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace NAIS.DAL
{
	/// <summary>
	/// 数据访问类:AIRWAY_POINT0
	/// </summary>
	public partial class AIRWAY_POINT0
	{
		public AIRWAY_POINT0()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("AIRWAY_POINT_ID", "AIRWAY_POINT0"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int AIRWAY_POINT_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from AIRWAY_POINT0");
			strSql.Append(" where AIRWAY_POINT_ID=@AIRWAY_POINT_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@AIRWAY_POINT_ID", SqlDbType.Int,4)			};
			parameters[0].Value = AIRWAY_POINT_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(NAIS.Model.AIRWAY_POINT0 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into AIRWAY_POINT0(");
			strSql.Append("AIRWAY_POINT_ID,AIRWAY_POINT_TYPE_ID,AIRWAY_POINT_NAME,OLD_NAME,CODE,SOUTH_OR_NORTH,LATITUDE,EAST_OR_WEST,LONGITUDE,MAGANETIC_VARIATION,E_OR_W,IS_REPORT,IDENTIFIER,FREQUENCE,CHNEL,CHCODE,ELEVATION,UPDATE_TIME,ACCOUNT,IS_TRANSMIT,IS_NATION_BOUNDIAR,PRONOUNCE_CODE,REMARK,SHOWTYPE,AIRPORT_ID,WORK_TIME,COORDINATETYPEID)");
			strSql.Append(" values (");
			strSql.Append("@AIRWAY_POINT_ID,@AIRWAY_POINT_TYPE_ID,@AIRWAY_POINT_NAME,@OLD_NAME,@CODE,@SOUTH_OR_NORTH,@LATITUDE,@EAST_OR_WEST,@LONGITUDE,@MAGANETIC_VARIATION,@E_OR_W,@IS_REPORT,@IDENTIFIER,@FREQUENCE,@CHNEL,@CHCODE,@ELEVATION,@UPDATE_TIME,@ACCOUNT,@IS_TRANSMIT,@IS_NATION_BOUNDIAR,@PRONOUNCE_CODE,@REMARK,@SHOWTYPE,@AIRPORT_ID,@WORK_TIME,@COORDINATETYPEID)");
			SqlParameter[] parameters = {
					new SqlParameter("@AIRWAY_POINT_ID", SqlDbType.Int,4),
					new SqlParameter("@AIRWAY_POINT_TYPE_ID", SqlDbType.Int,4),
					new SqlParameter("@AIRWAY_POINT_NAME", SqlDbType.NVarChar,30),
					new SqlParameter("@OLD_NAME", SqlDbType.NVarChar,32),
					new SqlParameter("@CODE", SqlDbType.NVarChar,10),
					new SqlParameter("@SOUTH_OR_NORTH", SqlDbType.NVarChar,1),
					new SqlParameter("@LATITUDE", SqlDbType.NVarChar,50),
					new SqlParameter("@EAST_OR_WEST", SqlDbType.NVarChar,1),
					new SqlParameter("@LONGITUDE", SqlDbType.NVarChar,50),
					new SqlParameter("@MAGANETIC_VARIATION", SqlDbType.Decimal,5),
					new SqlParameter("@E_OR_W", SqlDbType.NVarChar,1),
					new SqlParameter("@IS_REPORT", SqlDbType.Int,4),
					new SqlParameter("@IDENTIFIER", SqlDbType.NVarChar,4),
					new SqlParameter("@FREQUENCE", SqlDbType.NVarChar,10),
					new SqlParameter("@CHNEL", SqlDbType.NVarChar,10),
					new SqlParameter("@CHCODE", SqlDbType.NVarChar,1),
					new SqlParameter("@ELEVATION", SqlDbType.Int,4),
					new SqlParameter("@UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@ACCOUNT", SqlDbType.NVarChar,50),
					new SqlParameter("@IS_TRANSMIT", SqlDbType.Int,4),
					new SqlParameter("@IS_NATION_BOUNDIAR", SqlDbType.Int,4),
					new SqlParameter("@PRONOUNCE_CODE", SqlDbType.NVarChar,30),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,200),
					new SqlParameter("@SHOWTYPE", SqlDbType.Int,4),
					new SqlParameter("@AIRPORT_ID", SqlDbType.Int,4),
					new SqlParameter("@WORK_TIME", SqlDbType.NVarChar,50),
					new SqlParameter("@COORDINATETYPEID", SqlDbType.Int,4)};
			parameters[0].Value = model.AIRWAY_POINT_ID;
			parameters[1].Value = model.AIRWAY_POINT_TYPE_ID;
			parameters[2].Value = model.AIRWAY_POINT_NAME;
			parameters[3].Value = model.OLD_NAME;
			parameters[4].Value = model.CODE;
			parameters[5].Value = model.SOUTH_OR_NORTH;
			parameters[6].Value = model.LATITUDE;
			parameters[7].Value = model.EAST_OR_WEST;
			parameters[8].Value = model.LONGITUDE;
			parameters[9].Value = model.MAGANETIC_VARIATION;
			parameters[10].Value = model.E_OR_W;
			parameters[11].Value = model.IS_REPORT;
			parameters[12].Value = model.IDENTIFIER;
			parameters[13].Value = model.FREQUENCE;
			parameters[14].Value = model.CHNEL;
			parameters[15].Value = model.CHCODE;
			parameters[16].Value = model.ELEVATION;
			parameters[17].Value = model.UPDATE_TIME;
			parameters[18].Value = model.ACCOUNT;
			parameters[19].Value = model.IS_TRANSMIT;
			parameters[20].Value = model.IS_NATION_BOUNDIAR;
			parameters[21].Value = model.PRONOUNCE_CODE;
			parameters[22].Value = model.REMARK;
			parameters[23].Value = model.SHOWTYPE;
			parameters[24].Value = model.AIRPORT_ID;
			parameters[25].Value = model.WORK_TIME;
			parameters[26].Value = model.COORDINATETYPEID;

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
		public bool Update(NAIS.Model.AIRWAY_POINT0 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update AIRWAY_POINT0 set ");
			strSql.Append("AIRWAY_POINT_TYPE_ID=@AIRWAY_POINT_TYPE_ID,");
			strSql.Append("AIRWAY_POINT_NAME=@AIRWAY_POINT_NAME,");
			strSql.Append("OLD_NAME=@OLD_NAME,");
			strSql.Append("CODE=@CODE,");
			strSql.Append("SOUTH_OR_NORTH=@SOUTH_OR_NORTH,");
			strSql.Append("LATITUDE=@LATITUDE,");
			strSql.Append("EAST_OR_WEST=@EAST_OR_WEST,");
			strSql.Append("LONGITUDE=@LONGITUDE,");
			strSql.Append("MAGANETIC_VARIATION=@MAGANETIC_VARIATION,");
			strSql.Append("E_OR_W=@E_OR_W,");
			strSql.Append("IS_REPORT=@IS_REPORT,");
			strSql.Append("IDENTIFIER=@IDENTIFIER,");
			strSql.Append("FREQUENCE=@FREQUENCE,");
			strSql.Append("CHNEL=@CHNEL,");
			strSql.Append("CHCODE=@CHCODE,");
			strSql.Append("ELEVATION=@ELEVATION,");
			strSql.Append("UPDATE_TIME=@UPDATE_TIME,");
			strSql.Append("ACCOUNT=@ACCOUNT,");
			strSql.Append("IS_TRANSMIT=@IS_TRANSMIT,");
			strSql.Append("IS_NATION_BOUNDIAR=@IS_NATION_BOUNDIAR,");
			strSql.Append("PRONOUNCE_CODE=@PRONOUNCE_CODE,");
			strSql.Append("REMARK=@REMARK,");
			strSql.Append("SHOWTYPE=@SHOWTYPE,");
			strSql.Append("AIRPORT_ID=@AIRPORT_ID,");
			strSql.Append("WORK_TIME=@WORK_TIME,");
			strSql.Append("COORDINATETYPEID=@COORDINATETYPEID");
			strSql.Append(" where AIRWAY_POINT_ID=@AIRWAY_POINT_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@AIRWAY_POINT_TYPE_ID", SqlDbType.Int,4),
					new SqlParameter("@AIRWAY_POINT_NAME", SqlDbType.NVarChar,30),
					new SqlParameter("@OLD_NAME", SqlDbType.NVarChar,32),
					new SqlParameter("@CODE", SqlDbType.NVarChar,10),
					new SqlParameter("@SOUTH_OR_NORTH", SqlDbType.NVarChar,1),
					new SqlParameter("@LATITUDE", SqlDbType.NVarChar,50),
					new SqlParameter("@EAST_OR_WEST", SqlDbType.NVarChar,1),
					new SqlParameter("@LONGITUDE", SqlDbType.NVarChar,50),
					new SqlParameter("@MAGANETIC_VARIATION", SqlDbType.Decimal,5),
					new SqlParameter("@E_OR_W", SqlDbType.NVarChar,1),
					new SqlParameter("@IS_REPORT", SqlDbType.Int,4),
					new SqlParameter("@IDENTIFIER", SqlDbType.NVarChar,4),
					new SqlParameter("@FREQUENCE", SqlDbType.NVarChar,10),
					new SqlParameter("@CHNEL", SqlDbType.NVarChar,10),
					new SqlParameter("@CHCODE", SqlDbType.NVarChar,1),
					new SqlParameter("@ELEVATION", SqlDbType.Int,4),
					new SqlParameter("@UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@ACCOUNT", SqlDbType.NVarChar,50),
					new SqlParameter("@IS_TRANSMIT", SqlDbType.Int,4),
					new SqlParameter("@IS_NATION_BOUNDIAR", SqlDbType.Int,4),
					new SqlParameter("@PRONOUNCE_CODE", SqlDbType.NVarChar,30),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,200),
					new SqlParameter("@SHOWTYPE", SqlDbType.Int,4),
					new SqlParameter("@AIRPORT_ID", SqlDbType.Int,4),
					new SqlParameter("@WORK_TIME", SqlDbType.NVarChar,50),
					new SqlParameter("@COORDINATETYPEID", SqlDbType.Int,4),
					new SqlParameter("@AIRWAY_POINT_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.AIRWAY_POINT_TYPE_ID;
			parameters[1].Value = model.AIRWAY_POINT_NAME;
			parameters[2].Value = model.OLD_NAME;
			parameters[3].Value = model.CODE;
			parameters[4].Value = model.SOUTH_OR_NORTH;
			parameters[5].Value = model.LATITUDE;
			parameters[6].Value = model.EAST_OR_WEST;
			parameters[7].Value = model.LONGITUDE;
			parameters[8].Value = model.MAGANETIC_VARIATION;
			parameters[9].Value = model.E_OR_W;
			parameters[10].Value = model.IS_REPORT;
			parameters[11].Value = model.IDENTIFIER;
			parameters[12].Value = model.FREQUENCE;
			parameters[13].Value = model.CHNEL;
			parameters[14].Value = model.CHCODE;
			parameters[15].Value = model.ELEVATION;
			parameters[16].Value = model.UPDATE_TIME;
			parameters[17].Value = model.ACCOUNT;
			parameters[18].Value = model.IS_TRANSMIT;
			parameters[19].Value = model.IS_NATION_BOUNDIAR;
			parameters[20].Value = model.PRONOUNCE_CODE;
			parameters[21].Value = model.REMARK;
			parameters[22].Value = model.SHOWTYPE;
			parameters[23].Value = model.AIRPORT_ID;
			parameters[24].Value = model.WORK_TIME;
			parameters[25].Value = model.COORDINATETYPEID;
			parameters[26].Value = model.AIRWAY_POINT_ID;

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
		public bool Delete(int AIRWAY_POINT_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from AIRWAY_POINT0 ");
			strSql.Append(" where AIRWAY_POINT_ID=@AIRWAY_POINT_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@AIRWAY_POINT_ID", SqlDbType.Int,4)			};
			parameters[0].Value = AIRWAY_POINT_ID;

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
		public bool DeleteList(string AIRWAY_POINT_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from AIRWAY_POINT0 ");
			strSql.Append(" where AIRWAY_POINT_ID in ("+AIRWAY_POINT_IDlist + ")  ");
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
		public NAIS.Model.AIRWAY_POINT0 GetModel(int AIRWAY_POINT_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 AIRWAY_POINT_ID,AIRWAY_POINT_TYPE_ID,AIRWAY_POINT_NAME,OLD_NAME,CODE,SOUTH_OR_NORTH,LATITUDE,EAST_OR_WEST,LONGITUDE,MAGANETIC_VARIATION,E_OR_W,IS_REPORT,IDENTIFIER,FREQUENCE,CHNEL,CHCODE,ELEVATION,UPDATE_TIME,ACCOUNT,IS_TRANSMIT,IS_NATION_BOUNDIAR,PRONOUNCE_CODE,REMARK,SHOWTYPE,AIRPORT_ID,WORK_TIME,COORDINATETYPEID from AIRWAY_POINT0 ");
			strSql.Append(" where AIRWAY_POINT_ID=@AIRWAY_POINT_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@AIRWAY_POINT_ID", SqlDbType.Int,4)			};
			parameters[0].Value = AIRWAY_POINT_ID;

			NAIS.Model.AIRWAY_POINT0 model=new NAIS.Model.AIRWAY_POINT0();
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
		public NAIS.Model.AIRWAY_POINT0 DataRowToModel(DataRow row)
		{
			NAIS.Model.AIRWAY_POINT0 model=new NAIS.Model.AIRWAY_POINT0();
			if (row != null)
			{
				if(row["AIRWAY_POINT_ID"]!=null && row["AIRWAY_POINT_ID"].ToString()!="")
				{
					model.AIRWAY_POINT_ID=int.Parse(row["AIRWAY_POINT_ID"].ToString());
				}
				if(row["AIRWAY_POINT_TYPE_ID"]!=null && row["AIRWAY_POINT_TYPE_ID"].ToString()!="")
				{
					model.AIRWAY_POINT_TYPE_ID=int.Parse(row["AIRWAY_POINT_TYPE_ID"].ToString());
				}
				if(row["AIRWAY_POINT_NAME"]!=null)
				{
					model.AIRWAY_POINT_NAME=row["AIRWAY_POINT_NAME"].ToString();
				}
				if(row["OLD_NAME"]!=null)
				{
					model.OLD_NAME=row["OLD_NAME"].ToString();
				}
				if(row["CODE"]!=null)
				{
					model.CODE=row["CODE"].ToString();
				}
				if(row["SOUTH_OR_NORTH"]!=null)
				{
					model.SOUTH_OR_NORTH=row["SOUTH_OR_NORTH"].ToString();
				}
				if(row["LATITUDE"]!=null)
				{
					model.LATITUDE=row["LATITUDE"].ToString();
				}
				if(row["EAST_OR_WEST"]!=null)
				{
					model.EAST_OR_WEST=row["EAST_OR_WEST"].ToString();
				}
				if(row["LONGITUDE"]!=null)
				{
					model.LONGITUDE=row["LONGITUDE"].ToString();
				}
				if(row["MAGANETIC_VARIATION"]!=null && row["MAGANETIC_VARIATION"].ToString()!="")
				{
					model.MAGANETIC_VARIATION=decimal.Parse(row["MAGANETIC_VARIATION"].ToString());
				}
				if(row["E_OR_W"]!=null)
				{
					model.E_OR_W=row["E_OR_W"].ToString();
				}
				if(row["IS_REPORT"]!=null && row["IS_REPORT"].ToString()!="")
				{
					model.IS_REPORT=int.Parse(row["IS_REPORT"].ToString());
				}
				if(row["IDENTIFIER"]!=null)
				{
					model.IDENTIFIER=row["IDENTIFIER"].ToString();
				}
				if(row["FREQUENCE"]!=null)
				{
					model.FREQUENCE=row["FREQUENCE"].ToString();
				}
				if(row["CHNEL"]!=null)
				{
					model.CHNEL=row["CHNEL"].ToString();
				}
				if(row["CHCODE"]!=null)
				{
					model.CHCODE=row["CHCODE"].ToString();
				}
				if(row["ELEVATION"]!=null && row["ELEVATION"].ToString()!="")
				{
					model.ELEVATION=int.Parse(row["ELEVATION"].ToString());
				}
				if(row["UPDATE_TIME"]!=null && row["UPDATE_TIME"].ToString()!="")
				{
					model.UPDATE_TIME=DateTime.Parse(row["UPDATE_TIME"].ToString());
				}
				if(row["ACCOUNT"]!=null)
				{
					model.ACCOUNT=row["ACCOUNT"].ToString();
				}
				if(row["IS_TRANSMIT"]!=null && row["IS_TRANSMIT"].ToString()!="")
				{
					model.IS_TRANSMIT=int.Parse(row["IS_TRANSMIT"].ToString());
				}
				if(row["IS_NATION_BOUNDIAR"]!=null && row["IS_NATION_BOUNDIAR"].ToString()!="")
				{
					model.IS_NATION_BOUNDIAR=int.Parse(row["IS_NATION_BOUNDIAR"].ToString());
				}
				if(row["PRONOUNCE_CODE"]!=null)
				{
					model.PRONOUNCE_CODE=row["PRONOUNCE_CODE"].ToString();
				}
				if(row["REMARK"]!=null)
				{
					model.REMARK=row["REMARK"].ToString();
				}
				if(row["SHOWTYPE"]!=null && row["SHOWTYPE"].ToString()!="")
				{
					model.SHOWTYPE=int.Parse(row["SHOWTYPE"].ToString());
				}
				if(row["AIRPORT_ID"]!=null && row["AIRPORT_ID"].ToString()!="")
				{
					model.AIRPORT_ID=int.Parse(row["AIRPORT_ID"].ToString());
				}
				if(row["WORK_TIME"]!=null)
				{
					model.WORK_TIME=row["WORK_TIME"].ToString();
				}
				if(row["COORDINATETYPEID"]!=null && row["COORDINATETYPEID"].ToString()!="")
				{
					model.COORDINATETYPEID=int.Parse(row["COORDINATETYPEID"].ToString());
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
			strSql.Append("select AIRWAY_POINT_ID,AIRWAY_POINT_TYPE_ID,AIRWAY_POINT_NAME,OLD_NAME,CODE,SOUTH_OR_NORTH,LATITUDE,EAST_OR_WEST,LONGITUDE,MAGANETIC_VARIATION,E_OR_W,IS_REPORT,IDENTIFIER,FREQUENCE,CHNEL,CHCODE,ELEVATION,UPDATE_TIME,ACCOUNT,IS_TRANSMIT,IS_NATION_BOUNDIAR,PRONOUNCE_CODE,REMARK,SHOWTYPE,AIRPORT_ID,WORK_TIME,COORDINATETYPEID ");
			strSql.Append(" FROM AIRWAY_POINT0 ");
            strSql.Append(" where LONGITUDE is not null and LATITUDE is not null ");
            if (strWhere.Trim()!="")
			{
				strSql.Append(" and " + strWhere);
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
			strSql.Append(" AIRWAY_POINT_ID,AIRWAY_POINT_TYPE_ID,AIRWAY_POINT_NAME,OLD_NAME,CODE,SOUTH_OR_NORTH,LATITUDE,EAST_OR_WEST,LONGITUDE,MAGANETIC_VARIATION,E_OR_W,IS_REPORT,IDENTIFIER,FREQUENCE,CHNEL,CHCODE,ELEVATION,UPDATE_TIME,ACCOUNT,IS_TRANSMIT,IS_NATION_BOUNDIAR,PRONOUNCE_CODE,REMARK,SHOWTYPE,AIRPORT_ID,WORK_TIME,COORDINATETYPEID ");
			strSql.Append(" FROM AIRWAY_POINT0 ");
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
			strSql.Append("select count(1) FROM AIRWAY_POINT0 ");
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
				strSql.Append("order by T.AIRWAY_POINT_ID desc");
			}
			strSql.Append(")AS Row, T.*  from AIRWAY_POINT0 T ");
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
			parameters[0].Value = "AIRWAY_POINT0";
			parameters[1].Value = "AIRWAY_POINT_ID";
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

