using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Experts
{
    public static class PackageDB
    {
        /// <summary>
        /// Get Package List from Travel Experts database
        /// </summary>
        /// <returns>A list of all packages</returns>
        public static List<Package> GetPackages()
        {
            List<Package> packages = new List<Package>();
            Package package = null;

            SqlConnection connection = TravelExpertsDB.GetConnection();

            var sqlSelect = "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission FROM Packages";
            SqlCommand selectCmd = new SqlCommand(sqlSelect, connection);

            // execute
            try
            {
                // connect
                connection.Open();

                SqlDataReader dr = selectCmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    package = new Package();
                    package.PackageId = (int)dr["PackageId"];
                    package.PkgName = (string)dr["PkgName"];

                    if (dr["PkgStartDate"] == DBNull.Value)
                        package.PkgStartDate = null;
                    else
                        package.PkgStartDate = (DateTime)dr["PkgStartDate"];

                    if (dr["PkgEndDate"] == DBNull.Value)
                        package.PkgEndDate = null;
                    else
                        package.PkgEndDate = (DateTime)dr["PkgEndDate"];

                    package.PkgDesc = (string)dr["PkgDesc"];


                    if (dr["PkgBasePrice"] == DBNull.Value)
                        package.PkgBasePrice = null;
                    else
                        package.PkgBasePrice = (decimal)dr["PkgBasePrice"];


                    if (dr["PkgAgencyCommission"] == DBNull.Value)
                        package.PkgAgencyCommission = null;
                    else
                        package.PkgAgencyCommission = (decimal)dr["PkgAgencyCommission"];

                    packages.Add(package);

                }
                dr.Close();

                return packages;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
