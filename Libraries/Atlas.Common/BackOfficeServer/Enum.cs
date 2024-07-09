using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace Atlas.Common.BackOfficeServer
{
    public enum NewStatus
    {
        [Description("Pending")]
        Pending = 0,
        [Description("Edited")]
        Edited = 1,
        [Description("Approved")]
        Approved = 2,
        [Description("Rejected")]
        Rejected = 3,
        [Description("Draft")]
        Draft = 4
    }

    public enum Action
    {
        //[Description("Add")]
        //Add = 1,
        //[Description("Edit")]
        //Edit = 2,
        //[Description("Approve")]
        //Approve = 3,
        //[Description("Reject")]
        //Reject = 4,
        //[Description("View")]
        //View = 5,
        //[Description("Refer")]
        //Refer = 4,
        //[Description("Verify")]
        //Verify = 7,
        //[Description("Submit")]
        //Submit = 6,

        //[Description("Authorise")]
        //Authorise = 12

        [Description("VIEW")]
        VIEW = 1,
        [Description("EDIT")]
        EDIT = 2,
        [Description("NEW")]
        NEW = 3,
        [Description("COPY")]
        COPY = 4,
        [Description("UPDATE")]
        UPDATE = 5,
        [Description("SUBMIT")]
        SUBMIT = 6,
        [Description("VERIFY")]
        VERIFY = 7,
        [Description("REJECT")]
        REJECT = 8,
        [Description("AVS_CHECK")]
        AVS_CHECK = 9,
        [Description("CHECK_DIGIT")]
        CHECK_DIGIT = 10,
        [Description("SWIPE")]
        SWIPE = 11,

        [Description("AUTHORISE")]
        AUTHORISE = 12

        //[Description("View")]
        //View = 1,
        //[Description("Edit")]
        //Edit = 2,
        //[Description("New")]
        //New = 3,
        //[Description("Copy")]
        //Copy = 4,
        //[Description("Update")]
        //Update = 5,
        //[Description("Submit")]
        //Submit = 6,
        //[Description("Verify")]
        //Verify = 7,
        //[Description("Reject")]
        //Reject = 8,
        //[Description("Swipe")]
        //Swipe = 11,
        //[Description("Authorise")]
        //Authorise = 12,
    }

    public enum BO_Object
    {
        [Description("Customers")]
        Customers = 1,
        [Description("Accounts")]
        Accounts = 2,
        [Description("Applications")]
        Applications = 3

    }

    public enum BO_ObjectAPI
    {
        [Description("bankdetails")]
        bankdetails = 1,
        [Description("employerdetails")]
        employerdetails = 2,
        [Description("documents")]
        documents = 3,
        [Description("incomeexpense")]
        incomeexpense = 4,
        [Description("profile")]
        profile = 5,
        [Description("newcustomer")]
        newcustomer = 6,
        [Description("copyfromass")]
        copyfromass = 7

    }
}
