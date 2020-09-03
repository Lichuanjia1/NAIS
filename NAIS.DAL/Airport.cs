using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace NAIS.DAL
{
	/// <summary>
	/// 数据访问类:AIRPORT
	/// </summary>
	public partial class AIRPORT
	{
		public AIRPORT()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal AIRPORT_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from AIRPORT");
			strSql.Append(" where AIRPORT_ID=@AIRPORT_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@AIRPORT_ID", SqlDbType.Decimal,9)			};
			parameters[0].Value = AIRPORT_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(NAIS.Model.AIRPORT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into AIRPORT(");
			strSql.Append("AIRPORT_ID,FIR_ID,AIRPORT_CLASS_ID,BUREAU_ID,NAME,IDENTIFIER,IATA_CODE,TYPE,IS_INTERNATIONAL,OPEN_TIME,ADMIN_AUTHORITY,POST_ADDRESS,POST_CODE,AFTN_ADDRESS,FAX,PHONE_NUMBER,TRAFFIC_TYPE,LOCATION_DESC,SERVICE_CITY,CITY_REFERENCE_LOCATION,DIRECTION_FROM_CITY,DISTANCE_FROM_CITY,ELEVATION,LONGITUDE,EAST_OR_WEST,LATITUDE,SOUTH_OR_NORTH,REFER_TEMPERATURE,R_T_MONTH,E_OR_W,MAGANETIC_VARIATION,M_V_YEAR,M_V_SPEED_YEAR,TRANSITION_HEIGHT,TRANSITION_LEVEL,REMARK,CODE,HEIGHT_ANOMALY,UPDATE_TIME,ACCOUNT,CODE3,TRANSITION_ELEVATION,MAGANETIC_VARIATION_CHAR,PRONOUNCE_CODE,NAME_ENG,ISCAL,ISDIRECTORY,S_NS_P_TYPE,COORDINATETYPEID,Coordinate_ID,OutTime)");
			strSql.Append(" values (");
			strSql.Append("@AIRPORT_ID,@FIR_ID,@AIRPORT_CLASS_ID,@BUREAU_ID,@NAME,@IDENTIFIER,@IATA_CODE,@TYPE,@IS_INTERNATIONAL,@OPEN_TIME,@ADMIN_AUTHORITY,@POST_ADDRESS,@POST_CODE,@AFTN_ADDRESS,@FAX,@PHONE_NUMBER,@TRAFFIC_TYPE,@LOCATION_DESC,@SERVICE_CITY,@CITY_REFERENCE_LOCATION,@DIRECTION_FROM_CITY,@DISTANCE_FROM_CITY,@ELEVATION,@LONGITUDE,@EAST_OR_WEST,@LATITUDE,@SOUTH_OR_NORTH,@REFER_TEMPERATURE,@R_T_MONTH,@E_OR_W,@MAGANETIC_VARIATION,@M_V_YEAR,@M_V_SPEED_YEAR,@TRANSITION_HEIGHT,@TRANSITION_LEVEL,@REMARK,@CODE,@HEIGHT_ANOMALY,@UPDATE_TIME,@ACCOUNT,@CODE3,@TRANSITION_ELEVATION,@MAGANETIC_VARIATION_CHAR,@PRONOUNCE_CODE,@NAME_ENG,@ISCAL,@ISDIRECTORY,@S_NS_P_TYPE,@COORDINATETYPEID,@Coordinate_ID,@OutTime)");
			SqlParameter[] parameters = {
					new SqlParameter("@AIRPORT_ID", SqlDbType.Decimal,9),
					new SqlParameter("@FIR_ID", SqlDbType.Decimal,9),
					new SqlParameter("@AIRPORT_CLASS_ID", SqlDbType.Decimal,9),
					new SqlParameter("@BUREAU_ID", SqlDbType.Decimal,9),
					new SqlParameter("@NAME", SqlDbType.VarChar,30),
					new SqlParameter("@IDENTIFIER", SqlDbType.Char,4),
					new SqlParameter("@IATA_CODE", SqlDbType.Char,5),
					new SqlParameter("@TYPE", SqlDbType.VarChar,12),
					new SqlParameter("@IS_INTERNATIONAL", SqlDbType.Int,4),
					new SqlParameter("@OPEN_TIME", SqlDbType.VarChar,30),
					new SqlParameter("@ADMIN_AUTHORITY", SqlDbType.VarChar,50),
					new SqlParameter("@POST_ADDRESS", SqlDbType.VarChar,50),
					new SqlParameter("@POST_CODE", SqlDbType.VarChar,6),
					new SqlParameter("@AFTN_ADDRESS", SqlDbType.VarChar,30),
					new SqlParameter("@FAX", SqlDbType.VarChar,50),
					new SqlParameter("@PHONE_NUMBER", SqlDbType.VarChar,50),
					new SqlParameter("@TRAFFIC_TYPE", SqlDbType.VarChar,80),
					new SqlParameter("@LOCATION_DESC", SqlDbType.VarChar,150),
					new SqlParameter("@SERVICE_CITY", SqlDbType.VarChar,30),
					new SqlParameter("@CITY_REFERENCE_LOCATION", SqlDbType.VarChar,100),
					new SqlParameter("@DIRECTION_FROM_CITY", SqlDbType.VarChar,3),
					new SqlParameter("@DISTANCE_FROM_CITY", SqlDbType.Decimal,5),
					new SqlParameter("@ELEVATION", SqlDbType.Decimal,5),
					new SqlParameter("@LONGITUDE", SqlDbType.VarChar,30),
					new SqlParameter("@EAST_OR_WEST", SqlDbType.Char,1),
					new SqlParameter("@LATITUDE", SqlDbType.VarChar,30),
					new SqlParameter("@SOUTH_OR_NORTH", SqlDbType.Char,1),
					new SqlParameter("@REFER_TEMPERATURE", SqlDbType.Decimal,5),
					new SqlParameter("@R_T_MONTH", SqlDbType.VarChar,6),
					new SqlParameter("@E_OR_W", SqlDbType.Char,1),
					new SqlParameter("@MAGANETIC_VARIATION", SqlDbType.Decimal,5),
					new SqlParameter("@M_V_YEAR", SqlDbType.VarChar,4),
					new SqlParameter("@M_V_SPEED_YEAR", SqlDbType.Decimal,5),
					new SqlParameter("@TRANSITION_HEIGHT", SqlDbType.Decimal,5),
					new SqlParameter("@TRANSITION_LEVEL", SqlDbType.Decimal,5),
					new SqlParameter("@REMARK", SqlDbType.VarChar,200),
					new SqlParameter("@CODE", SqlDbType.VarChar,10),
					new SqlParameter("@HEIGHT_ANOMALY", SqlDbType.Decimal,9),
					new SqlParameter("@UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@ACCOUNT", SqlDbType.VarChar,50),
					new SqlParameter("@CODE3", SqlDbType.VarChar,3),
					new SqlParameter("@TRANSITION_ELEVATION", SqlDbType.Decimal,5),
					new SqlParameter("@MAGANETIC_VARIATION_CHAR", SqlDbType.VarChar,4),
					new SqlParameter("@PRONOUNCE_CODE", SqlDbType.VarChar,30),
					new SqlParameter("@NAME_ENG", SqlDbType.VarChar,50),
					new SqlParameter("@ISCAL", SqlDbType.Decimal,5),
					new SqlParameter("@ISDIRECTORY", SqlDbType.Decimal,5),
					new SqlParameter("@S_NS_P_TYPE", SqlDbType.VarChar,100),
					new SqlParameter("@COORDINATETYPEID", SqlDbType.Int,4),
					new SqlParameter("@Coordinate_ID", SqlDbType.Decimal,9),
					new SqlParameter("@OutTime", SqlDbType.Decimal,9)};
			parameters[0].Value = model.AIRPORT_ID;
			parameters[1].Value = model.FIR_ID;
			parameters[2].Value = model.AIRPORT_CLASS_ID;
			parameters[3].Value = model.BUREAU_ID;
			parameters[4].Value = model.NAME;
			parameters[5].Value = model.IDENTIFIER;
			parameters[6].Value = model.IATA_CODE;
			parameters[7].Value = model.TYPE;
			parameters[8].Value = model.IS_INTERNATIONAL;
			parameters[9].Value = model.OPEN_TIME;
			parameters[10].Value = model.ADMIN_AUTHORITY;
			parameters[11].Value = model.POST_ADDRESS;
			parameters[12].Value = model.POST_CODE;
			parameters[13].Value = model.AFTN_ADDRESS;
			parameters[14].Value = model.FAX;
			parameters[15].Value = model.PHONE_NUMBER;
			parameters[16].Value = model.TRAFFIC_TYPE;
			parameters[17].Value = model.LOCATION_DESC;
			parameters[18].Value = model.SERVICE_CITY;
			parameters[19].Value = model.CITY_REFERENCE_LOCATION;
			parameters[20].Value = model.DIRECTION_FROM_CITY;
			parameters[21].Value = model.DISTANCE_FROM_CITY;
			parameters[22].Value = model.ELEVATION;
			parameters[23].Value = model.LONGITUDE;
			parameters[24].Value = model.EAST_OR_WEST;
			parameters[25].Value = model.LATITUDE;
			parameters[26].Value = model.SOUTH_OR_NORTH;
			parameters[27].Value = model.REFER_TEMPERATURE;
			parameters[28].Value = model.R_T_MONTH;
			parameters[29].Value = model.E_OR_W;
			parameters[30].Value = model.MAGANETIC_VARIATION;
			parameters[31].Value = model.M_V_YEAR;
			parameters[32].Value = model.M_V_SPEED_YEAR;
			parameters[33].Value = model.TRANSITION_HEIGHT;
			parameters[34].Value = model.TRANSITION_LEVEL;
			parameters[35].Value = model.REMARK;
			parameters[36].Value = model.CODE;
			parameters[37].Value = model.HEIGHT_ANOMALY;
			parameters[38].Value = model.UPDATE_TIME;
			parameters[39].Value = model.ACCOUNT;
			parameters[40].Value = model.CODE3;
			parameters[41].Value = model.TRANSITION_ELEVATION;
			parameters[42].Value = model.MAGANETIC_VARIATION_CHAR;
			parameters[43].Value = model.PRONOUNCE_CODE;
			parameters[44].Value = model.NAME_ENG;
			parameters[45].Value = model.ISCAL;
			parameters[46].Value = model.ISDIRECTORY;
			parameters[47].Value = model.S_NS_P_TYPE;
			parameters[48].Value = model.COORDINATETYPEID;
			parameters[49].Value = model.Coordinate_ID;
			parameters[50].Value = model.OutTime;

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
		public bool Update(NAIS.Model.AIRPORT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update AIRPORT set ");
			strSql.Append("FIR_ID=@FIR_ID,");
			strSql.Append("AIRPORT_CLASS_ID=@AIRPORT_CLASS_ID,");
			strSql.Append("BUREAU_ID=@BUREAU_ID,");
			strSql.Append("NAME=@NAME,");
			strSql.Append("IDENTIFIER=@IDENTIFIER,");
			strSql.Append("IATA_CODE=@IATA_CODE,");
			strSql.Append("TYPE=@TYPE,");
			strSql.Append("IS_INTERNATIONAL=@IS_INTERNATIONAL,");
			strSql.Append("OPEN_TIME=@OPEN_TIME,");
			strSql.Append("ADMIN_AUTHORITY=@ADMIN_AUTHORITY,");
			strSql.Append("POST_ADDRESS=@POST_ADDRESS,");
			strSql.Append("POST_CODE=@POST_CODE,");
			strSql.Append("AFTN_ADDRESS=@AFTN_ADDRESS,");
			strSql.Append("FAX=@FAX,");
			strSql.Append("PHONE_NUMBER=@PHONE_NUMBER,");
			strSql.Append("TRAFFIC_TYPE=@TRAFFIC_TYPE,");
			strSql.Append("LOCATION_DESC=@LOCATION_DESC,");
			strSql.Append("SERVICE_CITY=@SERVICE_CITY,");
			strSql.Append("CITY_REFERENCE_LOCATION=@CITY_REFERENCE_LOCATION,");
			strSql.Append("DIRECTION_FROM_CITY=@DIRECTION_FROM_CITY,");
			strSql.Append("DISTANCE_FROM_CITY=@DISTANCE_FROM_CITY,");
			strSql.Append("ELEVATION=@ELEVATION,");
			strSql.Append("LONGITUDE=@LONGITUDE,");
			strSql.Append("EAST_OR_WEST=@EAST_OR_WEST,");
			strSql.Append("LATITUDE=@LATITUDE,");
			strSql.Append("SOUTH_OR_NORTH=@SOUTH_OR_NORTH,");
			strSql.Append("REFER_TEMPERATURE=@REFER_TEMPERATURE,");
			strSql.Append("R_T_MONTH=@R_T_MONTH,");
			strSql.Append("E_OR_W=@E_OR_W,");
			strSql.Append("MAGANETIC_VARIATION=@MAGANETIC_VARIATION,");
			strSql.Append("M_V_YEAR=@M_V_YEAR,");
			strSql.Append("M_V_SPEED_YEAR=@M_V_SPEED_YEAR,");
			strSql.Append("TRANSITION_HEIGHT=@TRANSITION_HEIGHT,");
			strSql.Append("TRANSITION_LEVEL=@TRANSITION_LEVEL,");
			strSql.Append("REMARK=@REMARK,");
			strSql.Append("CODE=@CODE,");
			strSql.Append("HEIGHT_ANOMALY=@HEIGHT_ANOMALY,");
			strSql.Append("UPDATE_TIME=@UPDATE_TIME,");
			strSql.Append("ACCOUNT=@ACCOUNT,");
			strSql.Append("CODE3=@CODE3,");
			strSql.Append("TRANSITION_ELEVATION=@TRANSITION_ELEVATION,");
			strSql.Append("MAGANETIC_VARIATION_CHAR=@MAGANETIC_VARIATION_CHAR,");
			strSql.Append("PRONOUNCE_CODE=@PRONOUNCE_CODE,");
			strSql.Append("NAME_ENG=@NAME_ENG,");
			strSql.Append("ISCAL=@ISCAL,");
			strSql.Append("ISDIRECTORY=@ISDIRECTORY,");
			strSql.Append("S_NS_P_TYPE=@S_NS_P_TYPE,");
			strSql.Append("COORDINATETYPEID=@COORDINATETYPEID,");
			strSql.Append("Coordinate_ID=@Coordinate_ID,");
			strSql.Append("OutTime=@OutTime");
			strSql.Append(" where AIRPORT_ID=@AIRPORT_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@FIR_ID", SqlDbType.Decimal,9),
					new SqlParameter("@AIRPORT_CLASS_ID", SqlDbType.Decimal,9),
					new SqlParameter("@BUREAU_ID", SqlDbType.Decimal,9),
					new SqlParameter("@NAME", SqlDbType.VarChar,30),
					new SqlParameter("@IDENTIFIER", SqlDbType.Char,4),
					new SqlParameter("@IATA_CODE", SqlDbType.Char,5),
					new SqlParameter("@TYPE", SqlDbType.VarChar,12),
					new SqlParameter("@IS_INTERNATIONAL", SqlDbType.Int,4),
					new SqlParameter("@OPEN_TIME", SqlDbType.VarChar,30),
					new SqlParameter("@ADMIN_AUTHORITY", SqlDbType.VarChar,50),
					new SqlParameter("@POST_ADDRESS", SqlDbType.VarChar,50),
					new SqlParameter("@POST_CODE", SqlDbType.VarChar,6),
					new SqlParameter("@AFTN_ADDRESS", SqlDbType.VarChar,30),
					new SqlParameter("@FAX", SqlDbType.VarChar,50),
					new SqlParameter("@PHONE_NUMBER", SqlDbType.VarChar,50),
					new SqlParameter("@TRAFFIC_TYPE", SqlDbType.VarChar,80),
					new SqlParameter("@LOCATION_DESC", SqlDbType.VarChar,150),
					new SqlParameter("@SERVICE_CITY", SqlDbType.VarChar,30),
					new SqlParameter("@CITY_REFERENCE_LOCATION", SqlDbType.VarChar,100),
					new SqlParameter("@DIRECTION_FROM_CITY", SqlDbType.VarChar,3),
					new SqlParameter("@DISTANCE_FROM_CITY", SqlDbType.Decimal,5),
					new SqlParameter("@ELEVATION", SqlDbType.Decimal,5),
					new SqlParameter("@LONGITUDE", SqlDbType.VarChar,30),
					new SqlParameter("@EAST_OR_WEST", SqlDbType.Char,1),
					new SqlParameter("@LATITUDE", SqlDbType.VarChar,30),
					new SqlParameter("@SOUTH_OR_NORTH", SqlDbType.Char,1),
					new SqlParameter("@REFER_TEMPERATURE", SqlDbType.Decimal,5),
					new SqlParameter("@R_T_MONTH", SqlDbType.VarChar,6),
					new SqlParameter("@E_OR_W", SqlDbType.Char,1),
					new SqlParameter("@MAGANETIC_VARIATION", SqlDbType.Decimal,5),
					new SqlParameter("@M_V_YEAR", SqlDbType.VarChar,4),
					new SqlParameter("@M_V_SPEED_YEAR", SqlDbType.Decimal,5),
					new SqlParameter("@TRANSITION_HEIGHT", SqlDbType.Decimal,5),
					new SqlParameter("@TRANSITION_LEVEL", SqlDbType.Decimal,5),
					new SqlParameter("@REMARK", SqlDbType.VarChar,200),
					new SqlParameter("@CODE", SqlDbType.VarChar,10),
					new SqlParameter("@HEIGHT_ANOMALY", SqlDbType.Decimal,9),
					new SqlParameter("@UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@ACCOUNT", SqlDbType.VarChar,50),
					new SqlParameter("@CODE3", SqlDbType.VarChar,3),
					new SqlParameter("@TRANSITION_ELEVATION", SqlDbType.Decimal,5),
					new SqlParameter("@MAGANETIC_VARIATION_CHAR", SqlDbType.VarChar,4),
					new SqlParameter("@PRONOUNCE_CODE", SqlDbType.VarChar,30),
					new SqlParameter("@NAME_ENG", SqlDbType.VarChar,50),
					new SqlParameter("@ISCAL", SqlDbType.Decimal,5),
					new SqlParameter("@ISDIRECTORY", SqlDbType.Decimal,5),
					new SqlParameter("@S_NS_P_TYPE", SqlDbType.VarChar,100),
					new SqlParameter("@COORDINATETYPEID", SqlDbType.Int,4),
					new SqlParameter("@Coordinate_ID", SqlDbType.Decimal,9),
					new SqlParameter("@OutTime", SqlDbType.Decimal,9),
					new SqlParameter("@AIRPORT_ID", SqlDbType.Decimal,9)};
			parameters[0].Value = model.FIR_ID;
			parameters[1].Value = model.AIRPORT_CLASS_ID;
			parameters[2].Value = model.BUREAU_ID;
			parameters[3].Value = model.NAME;
			parameters[4].Value = model.IDENTIFIER;
			parameters[5].Value = model.IATA_CODE;
			parameters[6].Value = model.TYPE;
			parameters[7].Value = model.IS_INTERNATIONAL;
			parameters[8].Value = model.OPEN_TIME;
			parameters[9].Value = model.ADMIN_AUTHORITY;
			parameters[10].Value = model.POST_ADDRESS;
			parameters[11].Value = model.POST_CODE;
			parameters[12].Value = model.AFTN_ADDRESS;
			parameters[13].Value = model.FAX;
			parameters[14].Value = model.PHONE_NUMBER;
			parameters[15].Value = model.TRAFFIC_TYPE;
			parameters[16].Value = model.LOCATION_DESC;
			parameters[17].Value = model.SERVICE_CITY;
			parameters[18].Value = model.CITY_REFERENCE_LOCATION;
			parameters[19].Value = model.DIRECTION_FROM_CITY;
			parameters[20].Value = model.DISTANCE_FROM_CITY;
			parameters[21].Value = model.ELEVATION;
			parameters[22].Value = model.LONGITUDE;
			parameters[23].Value = model.EAST_OR_WEST;
			parameters[24].Value = model.LATITUDE;
			parameters[25].Value = model.SOUTH_OR_NORTH;
			parameters[26].Value = model.REFER_TEMPERATURE;
			parameters[27].Value = model.R_T_MONTH;
			parameters[28].Value = model.E_OR_W;
			parameters[29].Value = model.MAGANETIC_VARIATION;
			parameters[30].Value = model.M_V_YEAR;
			parameters[31].Value = model.M_V_SPEED_YEAR;
			parameters[32].Value = model.TRANSITION_HEIGHT;
			parameters[33].Value = model.TRANSITION_LEVEL;
			parameters[34].Value = model.REMARK;
			parameters[35].Value = model.CODE;
			parameters[36].Value = model.HEIGHT_ANOMALY;
			parameters[37].Value = model.UPDATE_TIME;
			parameters[38].Value = model.ACCOUNT;
			parameters[39].Value = model.CODE3;
			parameters[40].Value = model.TRANSITION_ELEVATION;
			parameters[41].Value = model.MAGANETIC_VARIATION_CHAR;
			parameters[42].Value = model.PRONOUNCE_CODE;
			parameters[43].Value = model.NAME_ENG;
			parameters[44].Value = model.ISCAL;
			parameters[45].Value = model.ISDIRECTORY;
			parameters[46].Value = model.S_NS_P_TYPE;
			parameters[47].Value = model.COORDINATETYPEID;
			parameters[48].Value = model.Coordinate_ID;
			parameters[49].Value = model.OutTime;
			parameters[50].Value = model.AIRPORT_ID;

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
		public bool Delete(decimal AIRPORT_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from AIRPORT ");
			strSql.Append(" where AIRPORT_ID=@AIRPORT_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@AIRPORT_ID", SqlDbType.Decimal,9)			};
			parameters[0].Value = AIRPORT_ID;

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
		public bool DeleteList(string AIRPORT_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from AIRPORT ");
			strSql.Append(" where AIRPORT_ID in ("+AIRPORT_IDlist + ")  ");
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


        ///// <summary>
        ///// 得到一个对象实体
        ///// </summary>
        //public NAIS.Model.AIRPORT GetModel(decimal AIRPORT_ID)
        //{

        //	StringBuilder strSql=new StringBuilder();
        //	strSql.Append("select  top 1 AIRPORT_ID,FIR_ID,AIRPORT_CLASS_ID,BUREAU_ID,NAME,IDENTIFIER,IATA_CODE,TYPE,IS_INTERNATIONAL,OPEN_TIME,ADMIN_AUTHORITY,POST_ADDRESS,POST_CODE,AFTN_ADDRESS,FAX,PHONE_NUMBER,TRAFFIC_TYPE,LOCATION_DESC,SERVICE_CITY,CITY_REFERENCE_LOCATION,DIRECTION_FROM_CITY,DISTANCE_FROM_CITY,ELEVATION,LONGITUDE,EAST_OR_WEST,LATITUDE,SOUTH_OR_NORTH,REFER_TEMPERATURE,R_T_MONTH,E_OR_W,MAGANETIC_VARIATION,M_V_YEAR,M_V_SPEED_YEAR,TRANSITION_HEIGHT,TRANSITION_LEVEL,REMARK,CODE,HEIGHT_ANOMALY,UPDATE_TIME,ACCOUNT,CODE3,TRANSITION_ELEVATION,MAGANETIC_VARIATION_CHAR,PRONOUNCE_CODE,NAME_ENG,ISCAL,ISDIRECTORY,S_NS_P_TYPE,COORDINATETYPEID,Coordinate_ID,OutTime from AIRPORT ");
        //	strSql.Append(" where AIRPORT_ID=@AIRPORT_ID ");
        //	SqlParameter[] parameters = {
        //			new SqlParameter("@AIRPORT_ID", SqlDbType.Decimal,9)			};
        //	parameters[0].Value = AIRPORT_ID;

        //          NAIS.Model.AIRPORT model=new NAIS.Model.AIRPORT();
        //	DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
        //	if(ds.Tables[0].Rows.Count>0)
        //	{
        //		return DataRowToModel(ds.Tables[0].Rows[0]);
        //	}
        //	else
        //	{
        //		return null;
        //	}
        //}

        ///// <summary>
        ///// 得到一个对象实体------重载+1------------按机场名
        ///// </summary>
        //public NAIS.Model.AIRPORT GetModel(string AIRPORT_NAME)
        //{

        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("select  top 1 AIRPORT_ID,FIR_ID,AIRPORT_CLASS_ID,BUREAU_ID,NAME,IDENTIFIER,IATA_CODE,TYPE,IS_INTERNATIONAL,OPEN_TIME,ADMIN_AUTHORITY,POST_ADDRESS,POST_CODE,AFTN_ADDRESS,FAX,PHONE_NUMBER,TRAFFIC_TYPE,LOCATION_DESC,SERVICE_CITY,CITY_REFERENCE_LOCATION,DIRECTION_FROM_CITY,DISTANCE_FROM_CITY,ELEVATION,LONGITUDE,EAST_OR_WEST,LATITUDE,SOUTH_OR_NORTH,REFER_TEMPERATURE,R_T_MONTH,E_OR_W,MAGANETIC_VARIATION,M_V_YEAR,M_V_SPEED_YEAR,TRANSITION_HEIGHT,TRANSITION_LEVEL,REMARK,CODE,HEIGHT_ANOMALY,UPDATE_TIME,ACCOUNT,CODE3,TRANSITION_ELEVATION,MAGANETIC_VARIATION_CHAR,PRONOUNCE_CODE,NAME_ENG,ISCAL,ISDIRECTORY,S_NS_P_TYPE,COORDINATETYPEID,Coordinate_ID,OutTime from AIRPORT ");
        //    strSql.Append(" where NAME=@AIRPORT_ID ");
        //    SqlParameter[] parameters = {
        //            new SqlParameter("@NAME", SqlDbType.NVarChar,9)            };
        //    parameters[0].Value = AIRPORT_NAME;

        //    NAIS.Model.AIRPORT model = new NAIS.Model.AIRPORT();
        //    DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        return DataRowToModel(ds.Tables[0].Rows[0]);
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        ///<summary>
        ///使用委托尝试-----得到一个实体
        ///</summary>
        public NAIS.Model.AIRPORT GetModel(Func<StringBuilder,SqlParameter[]> func)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 AIRPORT_ID,FIR_ID,AIRPORT_CLASS_ID,BUREAU_ID,NAME,IDENTIFIER,IATA_CODE,TYPE,IS_INTERNATIONAL,OPEN_TIME,ADMIN_AUTHORITY,POST_ADDRESS,POST_CODE,AFTN_ADDRESS,FAX,PHONE_NUMBER,TRAFFIC_TYPE,LOCATION_DESC,SERVICE_CITY,CITY_REFERENCE_LOCATION,DIRECTION_FROM_CITY,DISTANCE_FROM_CITY,ELEVATION,LONGITUDE,EAST_OR_WEST,LATITUDE,SOUTH_OR_NORTH,REFER_TEMPERATURE,R_T_MONTH,E_OR_W,MAGANETIC_VARIATION,M_V_YEAR,M_V_SPEED_YEAR,TRANSITION_HEIGHT,TRANSITION_LEVEL,REMARK,CODE,HEIGHT_ANOMALY,UPDATE_TIME,ACCOUNT,CODE3,TRANSITION_ELEVATION,MAGANETIC_VARIATION_CHAR,PRONOUNCE_CODE,NAME_ENG,ISCAL,ISDIRECTORY,S_NS_P_TYPE,COORDINATETYPEID,Coordinate_ID,OutTime from AIRPORT ");
            SqlParameter[] parameters = func(strSql);
            //strSql.Append(" where AIRPORT_ID=@AIRPORT_ID ");
            //SqlParameter[] parameters = {
            //        new SqlParameter("@AIRPORT_ID", SqlDbType.Decimal,9)            };
            //parameters[0].Value = AIRPORT_ID;

            NAIS.Model.AIRPORT model = new NAIS.Model.AIRPORT();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
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
        public NAIS.Model.AIRPORT DataRowToModel(DataRow row)
		{
            NAIS.Model.AIRPORT model=new NAIS.Model.AIRPORT();
			if (row != null)
			{
				if(row["AIRPORT_ID"]!=null && row["AIRPORT_ID"].ToString()!="")
				{
					model.AIRPORT_ID=decimal.Parse(row["AIRPORT_ID"].ToString());
				}
				if(row["FIR_ID"]!=null && row["FIR_ID"].ToString()!="")
				{
					model.FIR_ID=decimal.Parse(row["FIR_ID"].ToString());
				}
				if(row["AIRPORT_CLASS_ID"]!=null && row["AIRPORT_CLASS_ID"].ToString()!="")
				{
					model.AIRPORT_CLASS_ID=decimal.Parse(row["AIRPORT_CLASS_ID"].ToString());
				}
				if(row["BUREAU_ID"]!=null && row["BUREAU_ID"].ToString()!="")
				{
					model.BUREAU_ID=decimal.Parse(row["BUREAU_ID"].ToString());
				}
				if(row["NAME"]!=null)
				{
					model.NAME=row["NAME"].ToString();
				}
				if(row["IDENTIFIER"]!=null)
				{
					model.IDENTIFIER=row["IDENTIFIER"].ToString();
				}
				if(row["IATA_CODE"]!=null)
				{
					model.IATA_CODE=row["IATA_CODE"].ToString();
				}
				if(row["TYPE"]!=null)
				{
					model.TYPE=row["TYPE"].ToString();
				}
				if(row["IS_INTERNATIONAL"]!=null && row["IS_INTERNATIONAL"].ToString()!="")
				{
					model.IS_INTERNATIONAL=int.Parse(row["IS_INTERNATIONAL"].ToString());
				}
				if(row["OPEN_TIME"]!=null)
				{
					model.OPEN_TIME=row["OPEN_TIME"].ToString();
				}
				if(row["ADMIN_AUTHORITY"]!=null)
				{
					model.ADMIN_AUTHORITY=row["ADMIN_AUTHORITY"].ToString();
				}
				if(row["POST_ADDRESS"]!=null)
				{
					model.POST_ADDRESS=row["POST_ADDRESS"].ToString();
				}
				if(row["POST_CODE"]!=null)
				{
					model.POST_CODE=row["POST_CODE"].ToString();
				}
				if(row["AFTN_ADDRESS"]!=null)
				{
					model.AFTN_ADDRESS=row["AFTN_ADDRESS"].ToString();
				}
				if(row["FAX"]!=null)
				{
					model.FAX=row["FAX"].ToString();
				}
				if(row["PHONE_NUMBER"]!=null)
				{
					model.PHONE_NUMBER=row["PHONE_NUMBER"].ToString();
				}
				if(row["TRAFFIC_TYPE"]!=null)
				{
					model.TRAFFIC_TYPE=row["TRAFFIC_TYPE"].ToString();
				}
				if(row["LOCATION_DESC"]!=null)
				{
					model.LOCATION_DESC=row["LOCATION_DESC"].ToString();
				}
				if(row["SERVICE_CITY"]!=null)
				{
					model.SERVICE_CITY=row["SERVICE_CITY"].ToString();
				}
				if(row["CITY_REFERENCE_LOCATION"]!=null)
				{
					model.CITY_REFERENCE_LOCATION=row["CITY_REFERENCE_LOCATION"].ToString();
				}
				if(row["DIRECTION_FROM_CITY"]!=null)
				{
					model.DIRECTION_FROM_CITY=row["DIRECTION_FROM_CITY"].ToString();
				}
				if(row["DISTANCE_FROM_CITY"]!=null && row["DISTANCE_FROM_CITY"].ToString()!="")
				{
					model.DISTANCE_FROM_CITY=decimal.Parse(row["DISTANCE_FROM_CITY"].ToString());
				}
				if(row["ELEVATION"]!=null && row["ELEVATION"].ToString()!="")
				{
					model.ELEVATION=decimal.Parse(row["ELEVATION"].ToString());
				}
				if(row["LONGITUDE"]!=null)
				{
					model.LONGITUDE=row["LONGITUDE"].ToString();
				}
				if(row["EAST_OR_WEST"]!=null)
				{
					model.EAST_OR_WEST=row["EAST_OR_WEST"].ToString();
				}
				if(row["LATITUDE"]!=null)
				{
					model.LATITUDE=row["LATITUDE"].ToString();
				}
				if(row["SOUTH_OR_NORTH"]!=null)
				{
					model.SOUTH_OR_NORTH=row["SOUTH_OR_NORTH"].ToString();
				}
				if(row["REFER_TEMPERATURE"]!=null && row["REFER_TEMPERATURE"].ToString()!="")
				{
					model.REFER_TEMPERATURE=decimal.Parse(row["REFER_TEMPERATURE"].ToString());
				}
				if(row["R_T_MONTH"]!=null)
				{
					model.R_T_MONTH=row["R_T_MONTH"].ToString();
				}
				if(row["E_OR_W"]!=null)
				{
					model.E_OR_W=row["E_OR_W"].ToString();
				}
				if(row["MAGANETIC_VARIATION"]!=null && row["MAGANETIC_VARIATION"].ToString()!="")
				{
					model.MAGANETIC_VARIATION=decimal.Parse(row["MAGANETIC_VARIATION"].ToString());
				}
				if(row["M_V_YEAR"]!=null)
				{
					model.M_V_YEAR=row["M_V_YEAR"].ToString();
				}
				if(row["M_V_SPEED_YEAR"]!=null && row["M_V_SPEED_YEAR"].ToString()!="")
				{
					model.M_V_SPEED_YEAR=decimal.Parse(row["M_V_SPEED_YEAR"].ToString());
				}
				if(row["TRANSITION_HEIGHT"]!=null && row["TRANSITION_HEIGHT"].ToString()!="")
				{
					model.TRANSITION_HEIGHT=decimal.Parse(row["TRANSITION_HEIGHT"].ToString());
				}
				if(row["TRANSITION_LEVEL"]!=null && row["TRANSITION_LEVEL"].ToString()!="")
				{
					model.TRANSITION_LEVEL=decimal.Parse(row["TRANSITION_LEVEL"].ToString());
				}
				if(row["REMARK"]!=null)
				{
					model.REMARK=row["REMARK"].ToString();
				}
				if(row["CODE"]!=null)
				{
					model.CODE=row["CODE"].ToString();
				}
				if(row["HEIGHT_ANOMALY"]!=null && row["HEIGHT_ANOMALY"].ToString()!="")
				{
					model.HEIGHT_ANOMALY=decimal.Parse(row["HEIGHT_ANOMALY"].ToString());
				}
				if(row["UPDATE_TIME"]!=null && row["UPDATE_TIME"].ToString()!="")
				{
					model.UPDATE_TIME=DateTime.Parse(row["UPDATE_TIME"].ToString());
				}
				if(row["ACCOUNT"]!=null)
				{
					model.ACCOUNT=row["ACCOUNT"].ToString();
				}
				if(row["CODE3"]!=null)
				{
					model.CODE3=row["CODE3"].ToString();
				}
				if(row["TRANSITION_ELEVATION"]!=null && row["TRANSITION_ELEVATION"].ToString()!="")
				{
					model.TRANSITION_ELEVATION=decimal.Parse(row["TRANSITION_ELEVATION"].ToString());
				}
				if(row["MAGANETIC_VARIATION_CHAR"]!=null)
				{
					model.MAGANETIC_VARIATION_CHAR=row["MAGANETIC_VARIATION_CHAR"].ToString();
				}
				if(row["PRONOUNCE_CODE"]!=null)
				{
					model.PRONOUNCE_CODE=row["PRONOUNCE_CODE"].ToString();
				}
				if(row["NAME_ENG"]!=null)
				{
					model.NAME_ENG=row["NAME_ENG"].ToString();
				}
				if(row["ISCAL"]!=null && row["ISCAL"].ToString()!="")
				{
					model.ISCAL=decimal.Parse(row["ISCAL"].ToString());
				}
				if(row["ISDIRECTORY"]!=null && row["ISDIRECTORY"].ToString()!="")
				{
					model.ISDIRECTORY=decimal.Parse(row["ISDIRECTORY"].ToString());
				}
				if(row["S_NS_P_TYPE"]!=null)
				{
					model.S_NS_P_TYPE=row["S_NS_P_TYPE"].ToString();
				}
				if(row["COORDINATETYPEID"]!=null && row["COORDINATETYPEID"].ToString()!="")
				{
					model.COORDINATETYPEID=int.Parse(row["COORDINATETYPEID"].ToString());
				}
				if(row["Coordinate_ID"]!=null && row["Coordinate_ID"].ToString()!="")
				{
					model.Coordinate_ID=decimal.Parse(row["Coordinate_ID"].ToString());
				}
				if(row["OutTime"]!=null && row["OutTime"].ToString()!="")
				{
					model.OutTime=decimal.Parse(row["OutTime"].ToString());
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
			strSql.Append("select AIRPORT_ID,FIR_ID,AIRPORT_CLASS_ID,BUREAU_ID,NAME,IDENTIFIER,IATA_CODE,TYPE,IS_INTERNATIONAL,OPEN_TIME,ADMIN_AUTHORITY,POST_ADDRESS,POST_CODE,AFTN_ADDRESS,FAX,PHONE_NUMBER,TRAFFIC_TYPE,LOCATION_DESC,SERVICE_CITY,CITY_REFERENCE_LOCATION,DIRECTION_FROM_CITY,DISTANCE_FROM_CITY,ELEVATION,LONGITUDE,EAST_OR_WEST,LATITUDE,SOUTH_OR_NORTH,REFER_TEMPERATURE,R_T_MONTH,E_OR_W,MAGANETIC_VARIATION,M_V_YEAR,M_V_SPEED_YEAR,TRANSITION_HEIGHT,TRANSITION_LEVEL,REMARK,CODE,HEIGHT_ANOMALY,UPDATE_TIME,ACCOUNT,CODE3,TRANSITION_ELEVATION,MAGANETIC_VARIATION_CHAR,PRONOUNCE_CODE,NAME_ENG,ISCAL,ISDIRECTORY,S_NS_P_TYPE,COORDINATETYPEID,Coordinate_ID,OutTime ");
			strSql.Append(" FROM AIRPORT ");
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
			strSql.Append(" AIRPORT_ID,FIR_ID,AIRPORT_CLASS_ID,BUREAU_ID,NAME,IDENTIFIER,IATA_CODE,TYPE,IS_INTERNATIONAL,OPEN_TIME,ADMIN_AUTHORITY,POST_ADDRESS,POST_CODE,AFTN_ADDRESS,FAX,PHONE_NUMBER,TRAFFIC_TYPE,LOCATION_DESC,SERVICE_CITY,CITY_REFERENCE_LOCATION,DIRECTION_FROM_CITY,DISTANCE_FROM_CITY,ELEVATION,LONGITUDE,EAST_OR_WEST,LATITUDE,SOUTH_OR_NORTH,REFER_TEMPERATURE,R_T_MONTH,E_OR_W,MAGANETIC_VARIATION,M_V_YEAR,M_V_SPEED_YEAR,TRANSITION_HEIGHT,TRANSITION_LEVEL,REMARK,CODE,HEIGHT_ANOMALY,UPDATE_TIME,ACCOUNT,CODE3,TRANSITION_ELEVATION,MAGANETIC_VARIATION_CHAR,PRONOUNCE_CODE,NAME_ENG,ISCAL,ISDIRECTORY,S_NS_P_TYPE,COORDINATETYPEID,Coordinate_ID,OutTime ");
			strSql.Append(" FROM AIRPORT ");
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
			strSql.Append("select count(1) FROM AIRPORT ");
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
				strSql.Append("order by T.AIRPORT_ID desc");
			}
			strSql.Append(")AS Row, T.*  from AIRPORT T ");
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
			parameters[0].Value = "AIRPORT";
			parameters[1].Value = "AIRPORT_ID";
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

