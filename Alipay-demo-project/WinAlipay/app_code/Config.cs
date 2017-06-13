﻿using System;
using System.Collections.Generic;
using System.IO;
//using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Config
/// </summary>
namespace Com.Alipay
{
    public class Config
    {

        /*****************************生产环境的测试数据*****************************
        public static string alipay_public_key = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Demo\\alipay_rsa_public_key.pem";
        //这里要配置没有经过PKCS8转换的原始私钥
        public static string merchant_private_key = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Demo\\rsa_private_key.pem ";
        public static string merchant_public_key = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Demo\\rsa_public_key.pem";
        public static string appId = "2016080500173432";   
        public static string serverUrl = "https://openapi.alipay.com/gateway.do";
        public static string mapiUrl = "https://mapi.alipay.com/gateway.do";
        public static string monitor2088222892972212Url = "http://mcloudmonitor.com/gateway.do";
        public static string pid = "2088102170069329"; 
         /*****************************生产环境的测试数据*****************************/



        /*****************************开发环境的测试数据*****************************/
        public static string alipay_public_key = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Demo\\alipay_rsa_public_key.pem";
                   //这里要配置没有经过PKCS8转换的原始私钥
        public static string merchant_private_key = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Demo\\rsa_private_key.pem";
        public static string merchant_public_key = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Demo\\rsa_public_key.pem";
        public static string appId = "2016080500173432";
        public static string serverUrl = "https://openapi.alipaydev.com/gateway.do";
              public static string     mapiUrl = "http://mapi.stable.alipay.net/gateway.do";
              public static string pid = "2088102170069329";
         /*****************************开发环境的测试数据*****************************/


         public static string charset = "utf-8";//"utf-8";
         public static string sign_type = "RSA";
         public static string version = "2.0";
     

        public Config()
        {
            //
        }

        public static string getMerchantPublicKeyStr()
        {
            StreamReader sr = new StreamReader(merchant_public_key);
            string pubkey = sr.ReadToEnd();
            sr.Close();
            if (pubkey != null)
            {
              pubkey=  pubkey.Replace("-----BEGIN PUBLIC KEY-----", "");
              pubkey = pubkey.Replace("-----END PUBLIC KEY-----", "");
              pubkey = pubkey.Replace("\r", "");
              pubkey = pubkey.Replace("\n", "");
            }
            return pubkey;
        }

        public static string getMerchantPriveteKeyStr()
        {
            StreamReader sr = new StreamReader(merchant_private_key);
            string pubkey = sr.ReadToEnd();
            sr.Close();
            if (pubkey != null)
            {
                pubkey = pubkey.Replace("-----BEGIN PUBLIC KEY-----", "");
                pubkey = pubkey.Replace("-----END PUBLIC KEY-----", "");
                pubkey = pubkey.Replace("\r", "");
                pubkey = pubkey.Replace("\n", "");
            }
            return pubkey;
        }

    }
}