﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserInfo
/// </summary>
public class UserInfo
{
    String stateOrProvince;
    String streetAddress;
    String zipCode;
    String firstName;
    String lastName;
    String homePhone;
    String cellPhone;
    String emailAddress;
    String password;
    String securityQuestion;
    String securityQuestionAnswer;
    List<BillPayEntry> myBillPayments;
   
    public String StateOrProvince
    {
        get { return stateOrProvince; } /*ADD THE PROPERTIES AS SHOWN*/
        set { stateOrProvince = value; } /*FOR THE REMAINING FIELDS.*/
    }
    public String StreetAddress
    {
        get { return streetAddress; } /*ADD THE PROPERTIES AS SHOWN*/
        set { streetAddress = value; } /*FOR THE REMAINING FIELDS.*/
    }
    public String ZipCode
    {
        get { return zipCode; } /*ADD THE PROPERTIES AS SHOWN*/
        set { zipCode = value; } /*FOR THE REMAINING FIELDS.*/
    }
    public String FirstName
    {
        get { return firstName; } /*ADD THE PROPERTIES AS SHOWN*/
        set { firstName = value; } /*FOR THE REMAINING FIELDS.*/
    }
    public String LastName
    {
        get { return lastName; } /*ADD THE PROPERTIES AS SHOWN*/
        set {lastName = value; } /*FOR THE REMAINING FIELDS.*/
    }
    public String HomePhone
    {
        get { return homePhone; } /*ADD THE PROPERTIES AS SHOWN*/
        set { homePhone = value; } /*FOR THE REMAINING FIELDS.*/
    }
    public String CellPhone
    {
        get { return cellPhone; } /*ADD THE PROPERTIES AS SHOWN*/
        set { cellPhone = value; } /*FOR THE REMAINING FIELDS.*/
    }
    public String EmailAddress
    {
        get { return emailAddress; } /*ADD THE PROPERTIES AS SHOWN*/
        set { emailAddress = value; } /*FOR THE REMAINING FIELDS.*/
    }
    public String Password
    {
        get { return password; } /*ADD THE PROPERTIES AS SHOWN*/
        set { password = value; } /*FOR THE REMAINING FIELDS.*/
    }
    public String SecurityQuestion
    {
        get { return securityQuestion; } /*ADD THE PROPERTIES AS SHOWN*/
        set { securityQuestion = value; } /*FOR THE REMAINING FIELDS.*/
    }
    public String SecurityQuestionAnswer
    {
        get { return securityQuestionAnswer; } /*ADD THE PROPERTIES AS SHOWN*/
        set { securityQuestionAnswer = value; } /*FOR THE REMAINING FIELDS.*/
    }
    public List<BillPayEntry> MyBillPayments
    {
        get { return myBillPayments; } /*ADD THE PROPERTIES AS SHOWN*/
        set { myBillPayments = value; } /*FOR THE REMAINING FIELDS.*/
    }
}