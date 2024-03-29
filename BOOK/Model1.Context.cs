﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BOOK
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DBMVCEntities : DbContext
    {
        public DBMVCEntities()
            : base("name=DBMVCEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<adminn> adminns { get; set; }
        public virtual DbSet<book> books { get; set; }
    
        public virtual int sp_ainsert(string na, string email, string uname, string pw)
        {
            var naParameter = na != null ?
                new ObjectParameter("na", na) :
                new ObjectParameter("na", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var unameParameter = uname != null ?
                new ObjectParameter("uname", uname) :
                new ObjectParameter("uname", typeof(string));
    
            var pwParameter = pw != null ?
                new ObjectParameter("pw", pw) :
                new ObjectParameter("pw", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ainsert", naParameter, emailParameter, unameParameter, pwParameter);
        }
    
        public virtual int sp_binsert(string na, Nullable<int> pr, string au, string im)
        {
            var naParameter = na != null ?
                new ObjectParameter("na", na) :
                new ObjectParameter("na", typeof(string));
    
            var prParameter = pr.HasValue ?
                new ObjectParameter("pr", pr) :
                new ObjectParameter("pr", typeof(int));
    
            var auParameter = au != null ?
                new ObjectParameter("au", au) :
                new ObjectParameter("au", typeof(string));
    
            var imParameter = im != null ?
                new ObjectParameter("im", im) :
                new ObjectParameter("im", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_binsert", naParameter, prParameter, auParameter, imParameter);
        }
    
        public virtual int sp_login(string una, string pwd, ObjectParameter status)
        {
            var unaParameter = una != null ?
                new ObjectParameter("una", una) :
                new ObjectParameter("una", typeof(string));
    
            var pwdParameter = pwd != null ?
                new ObjectParameter("pwd", pwd) :
                new ObjectParameter("pwd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_login", unaParameter, pwdParameter, status);
        }
    
        public virtual ObjectResult<sp_aprofile_Result> sp_aprofile(string una)
        {
            var unaParameter = una != null ?
                new ObjectParameter("una", una) :
                new ObjectParameter("una", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_aprofile_Result>("sp_aprofile", unaParameter);
        }
    
        public virtual int sp_apupdate(string username, string email, string na)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var naParameter = na != null ?
                new ObjectParameter("na", na) :
                new ObjectParameter("na", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_apupdate", usernameParameter, emailParameter, naParameter);
        }
    
        public virtual int sp_pwdchange(string uname, string oldpwd, string newpwd, ObjectParameter status)
        {
            var unameParameter = uname != null ?
                new ObjectParameter("uname", uname) :
                new ObjectParameter("uname", typeof(string));
    
            var oldpwdParameter = oldpwd != null ?
                new ObjectParameter("oldpwd", oldpwd) :
                new ObjectParameter("oldpwd", typeof(string));
    
            var newpwdParameter = newpwd != null ?
                new ObjectParameter("newpwd", newpwd) :
                new ObjectParameter("newpwd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_pwdchange", unameParameter, oldpwdParameter, newpwdParameter, status);
        }
    
        public virtual ObjectResult<sp_bview_Result> sp_bview()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_bview_Result>("sp_bview");
        }
    }
}
