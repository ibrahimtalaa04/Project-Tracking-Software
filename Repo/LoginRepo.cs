﻿using DbManagerStandard;
using Oracle.ManagedDataAccess.Client;
using ProjectTrackingSoftware.Models;
using System.Data;

namespace ProjectTrackingSoftware.Repo
{
    public interface ILogin
    {
        public Task<bool> OnPostLogin(LoginModel model);
    }
    public class LoginRepo : ILogin
    {   
        static dbAccess con;
        static OracleConnection aOracleConnection;
        public static UserModel currentUser = null;
        public Task<bool> OnPostLogin(LoginModel model)
        {
            LoginUser(model);
            throw new NotImplementedException();
        }

        static void Open()
        {
            con = new dbAccess();
            aOracleConnection = con.get_con();
        }
        static void Close()
        {
            con.Close(aOracleConnection);
        }



        public static void LoginUser(LoginModel user)
        {
            Open();
            OracleTransaction CmdTrans = aOracleConnection.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                LoginUser(user, CmdTrans, aOracleConnection);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                Close();
            }

        }

        public static UserModel LoginUser(LoginModel inputLoginVM, OracleTransaction CmdTrans, OracleConnection aOracleConnection)


        {
            List<UserModel> users = GetUserData();

            int r = 0;
            try
            {
                OracleCommand cmd = aOracleConnection.CreateCommand();
                cmd.Transaction = CmdTrans;
                cmd.CommandType = CommandType.Text;
                if (users.Count > 0)
                {
                    foreach (UserModel user in users)
                    {
                        if (user.Email.Equals(inputLoginVM.Email) && user.Password.Equals(inputLoginVM.Password))
                        {
                            currentUser = new UserModel() { };
                            currentUser.Email = inputLoginVM.Email;
                            currentUser.Password = inputLoginVM.Password;
                            currentUser.Id = user.Id;
                            currentUser.FirstName = user.FirstName;
                            return currentUser;
                        }
                    }

                }
                else
                {
                    r = 0;
                    return null;
                }

            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            return null;
        }
        public static List<UserModel> GetUserData()
        {
            Open();
            OracleTransaction CmdTrans = aOracleConnection.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                return GetUserData(CmdTrans, aOracleConnection);
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Close();
            }
        }
        public static List<UserModel> GetUserData(OracleTransaction CmdTrans, OracleConnection aOracleConnection)
        {
            List<UserModel> lst = new List<UserModel>();
            try
            {
                OracleCommand cmd = aOracleConnection.CreateCommand();
                cmd.Transaction = CmdTrans;
                cmd.CommandType = CommandType.Text;
                var cmdText = @"SELECT * FROM AppUser";
                cmd.CommandText = cmdText;
                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int id = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
                        string email = dt.Rows[i]["EMAIL"].ToString();
                        string fullname = dt.Rows[i]["FName"].ToString();
                        string password = dt.Rows[i]["PASSWORD"].ToString();
                        string ConfirmPassword = dt.Rows[i]["ConfirmPassword"].ToString();
                        lst.Add(new UserModel() { Id = id, Email = email, FirstName = fullname,  Password = password });
                    }
                }
                return lst;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

    }


}