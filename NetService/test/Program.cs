﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceCore.Net;
using System.Threading;
using ServiceCore.Base;
using ServiceCore.Model;

namespace test
{
    class Program
    {
        static TeachNet tn;
        static string test;
        static void  Main(string[] args)
        {
            tn = new TeachNet("201585081", "19970401");
            string testT = "\r\n\r\n\r\n\r\n < html lang =\"zh-CN\">\r\n<head>\r\n<title>学生选课结果</title>\r\n\r\n\r\n<meta http-equiv=\"Content-Type\" content=\"text/html; charset=GBK\">\r\n<link href=\"/css/newcss/project.css\" rel=\"stylesheet\" type=\"text/css\">\r\n\r\n</head>\r\n<body topmargin=\"0\" leftmargin=\"0\" rightmargin=\"0\" style=\"overflow:auto;\">\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n<script type=\"text/javascript\">\r\n  function dy(){\r\n    var today = new Date();\r\n   var timeStr = today.format(\"YYYY年MM月dd日hh小时mm分ss秒\");\r\n   var time = document.getElementById(\"xssj\");\r\n   time.innerHTML=timeStr;\r\n   beforedy();\r\n   document.execCommand(\"print\");\r\n   afterdy();\r\n  }\r\n  Date.prototype.format = function(format){\r\n\t var o = {\r\n\t \"Y+\" :  this.getFullYear(), \r\n\t  \"M+\" :  this.getMonth()+1,  //month\r\n\t  \"d+\" :  this.getDate(),     //day\r\n\t  \"h+\" :  this.getHours(),    //hour\r\n\t      \"m+\" :  this.getMinutes(),  //minute\r\n\t      \"s+\" :  this.getSeconds(), //second\r\n\t      \"q+\" :  Math.floor((this.getMonth()+3)/3),  //quarter\r\n\t      \"S\"  :  this.getMilliseconds() //millisecond\r\n\t   }\r\n\t   if(/(y+)/.test(format)) {\r\n\t    format = format.replace(RegExp.$1, (this.getFullYear()+\"\").substr(4 - RegExp.$1.length));\r\n\t   }\r\n\t \r\n\t   for(var k in o) {\r\n\t    if(new RegExp(\"(\"+ k +\")\").test(format)) {\r\n\t      format = format.replace(RegExp.$1, RegExp.$1.length==1 ? o[k] : (\"00\"+ o[k]).substr((\"\"+ o[k]).length));\r\n\t    }\r\n\t   }\r\n\t return format;\r\n}\r\n  function beforedy(){\r\n    document.getElementById(\"tblHead\").style.display=\"none\";\r\n\t\r\n  var  yhlbss =  document.getElementById(\"yhlb\").value; \r\n   if(\"01\"== yhlbss){\r\n    document.getElementById(\"xsxx\").style.display=\"\";\r\n    document.getElementById(\"kbxx\").style.display=\"none\";\r\n   }\r\n    //document.getElementById(\"xsxx\").style.display=\"\";  //cxl\r\n    //document.getElementById(\"kbxx\").style.display=\"none\"; //cxl\r\n\t\r\n  }\r\n  function afterdy(){\r\n    document.getElementById(\"tblHead\").style.display=\"\";\r\n     var  yhlbss =  document.getElementById(\"yhlb\").value; \r\n   if(\"01\"== yhlbss){\r\n     document.getElementById(\"xsxx\").style.display=\"none\"; \r\n     document.getElementById(\"kbxx\").style.display=\"\";\r\n\t document.getElementById(\"kclist\").style.display=\"\";\r\n   }\r\n   \r\n   \r\n   \r\n\t\r\n  }\r\n</script>\r\n\r\n\r\n<table width=\"100%\" border=\"0\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\">\r\n<tr><td class=\"Linetop\"></td>\r\n</tr>\r\n</table>\r\n     \r\n<input id=\"yhlb\" type=\"hidden\" name=\"yhlb\" size=\"15\" value=\"01\" style=\"width: 50px;\" />\r\n<table width=\"100%\"  border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"title\" id=\"tblHead\">\r\n <tr>\r\n  <td>\r\n   <table border=\"0\" width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" >\r\n   <tr>\r\n   <td width=\"50%\" align=\"left\" valign=\"middle\">&nbsp;<b>选课结果(已安排时间地点)</b>&nbsp;</td>\r\n\r\n<td width=\"50%\" align=\"right\">\r\n\r\n2018年03月27日23时24分\r\n\r\n<!-- 打印功能090604hnn -->\r\n<td width=\"10\" align=\"center\"><img  src=\"/img/icon/space.gif\"></td>\r\n\t                           <td width=\"10\" align=\"center\">\r\n\t                           <img  src=\"/img/icon/print.gif\" \r\n\t                           onClick=\"dy()\" title=\"打印\"  style=\"cursor:hand\">\r\n\t                           </td>\r\n\r\n</td>\r\n\r\n</tr>\r\n   </table>\r\n  </tr>\r\n</table>\r\n<table width=\"100%\" border=\"0\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\"  >\r\n <tr>\r\n  <td class=\"Linetop\"></td>\r\n </tr>\r\n</table>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n<link href=\"/css/newcss/project.css\" rel=\"stylesheet\" type=\"text/css\">\r\n\r\n\r\n\r\n\r\n\r\n\r\n<!-- 学生信息090604hnn -->\r\n\r\n<table width=\"99%\" border=\"0\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\" id=\"xsxx\" style=\"display:none\">\r\n  <tr> \r\n    <td class=\"infoBg1\">&nbsp;</td>\r\n    <td class=\"infoBg2\"><table border=\"0\" cellpadding=\"0\" cellspacing=\"0\">\r\n        <tr> \r\n          <td class=\"legend\">基本信息</td>\r\n        </tr>\r\n      </table></td>\r\n    <td class=\"infoBg3\">&nbsp;</td>\r\n  </tr>\r\n  <tr> \r\n    <td class=\"infoBg4\">&nbsp;</td>\r\n    <td>\r\n\r\n\t<table width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"titleTop3\">\r\n\t\t<tr>\r\n\t\t\t\r\n\t\t\t<td valign=\"top\"> \r\n\t\t\t\t<table border=\"0\" cellspacing=\"0\" cellpadding=\"2\" >\r\n\t\t\t\t\t<tr> \r\n\t\t\t\t\t\t<td width=\"100\" align=\"right\"  class=\"fieldName\" NOWRAP >学号:</td>\r\n\t\t\t\t\t\t <td >\t\t\t\t\t\t \r\n\t\t\t\t\t\t     201585081\r\n\t\t\t\t\t\t </td>\r\n\t\t\t\t\t\t<td width=\"3\">&nbsp;</td>\r\n\t\t\t\t\t\t<td width=\"145\" class=\"fieldName\">\r\n\t\t\t\t\t\t\t姓名:\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td width=\"3\">&nbsp;</td>\r\n\t\t\t\t\t\t<td>  \r\n\t\t\t\t\t\t\t赵立璟\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t<tr> \r\n\t\t\t\t\t\t<td height=\"3\" colspan=\"6\" ></td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t<tr> \r\n\t\t\t\t\t\t<td width=\"100\" align=\"right\"  class=\"fieldName\" NOWRAP >班级:</td>\r\n\t\t\t\t\t\t <td >\t\t\t\t\t\t \r\n\t\t\t\t\t\t     电计1503\r\n\t\t\t\t\t\t </td>\r\n\t\t\t\t\t\t<td width=\"3\">&nbsp;</td>\r\n\t\t\t\t\t\t<td width=\"145\" class=\"fieldName\">\r\n\t\t\t\t\t\t\t打印日期:\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td width=\"3\">&nbsp;</td>\r\n\t\t\t\t\t\t<td>  \r\n\t\t\t\t\t\t\t<div id=\"curtime\"><strong id=\"xssj\"></strong></div>\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t</tr>\t\t\t\t\t\t\t\r\n\r\n\t\t\t\t</table>\r\n\t\t\t\t</td>\r\n\t\t</tr>\r\n\t</table>\r\n\t</td>\r\n    <td class=\"infoBg5\">&nbsp;</td>\r\n  </tr>\r\n  <tr> \r\n    <td class=\"infoBg6\">&nbsp;</td>\r\n    <td class=\"infoBg2\">&nbsp;</td>\r\n    <td class=\"infoBg8\">&nbsp;</td>\r\n  </tr>\r\n</table>   \r\n\t<table width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"titleTop2\" id=\"kbxx\">\r\n\t\t <tr>\r\n\t\t  <td class=\"pageAlign\">\r\n\t\t   <table cellpadding=\"0\" width=\"100%\" class=\"displayTag\" cellspacing=\"0\" border=\"1\" id=\"user\">\r\n\t\t\t\t<tr>\r\n    <td colspan=\"2\" class=\"sortable\">&nbsp;</td>\r\n\r\n\r\n    <td width=\"13%\" class=\"sortable\">\r\n    <div align=\"center\">\r\n\t\r\n\t\t\t星期一\r\n\t\t\t\r\n\t</div>\r\n\t</td>\r\n\r\n    <td width=\"13%\" class=\"sortable\">\r\n    <div align=\"center\">\r\n\t\r\n\t\t\t星期二\r\n\t\t\t\r\n\t</div>\r\n\t</td>\r\n\r\n    <td width=\"13%\" class=\"sortable\">\r\n    <div align=\"center\">\r\n\t\r\n\t\t\t星期三\r\n\t\t\t\r\n\t</div>\r\n\t</td>\r\n\r\n    <td width=\"13%\" class=\"sortable\">\r\n    <div align=\"center\">\r\n\t\r\n\t\t\t星期四\r\n\t\t\t\r\n\t</div>\r\n\t</td>\r\n\r\n    <td width=\"13%\" class=\"sortable\">\r\n    <div align=\"center\">\r\n\t\r\n\t\t\t星期五\r\n\t\t\t\r\n\t</div>\r\n\t</td>\r\n\r\n    <td width=\"13%\" class=\"sortable\">\r\n    <div align=\"center\">\r\n\t\r\n\t\t\t星期六\r\n\t\t\t\r\n\t</div>\r\n\t</td>\r\n\r\n    <td width=\"13%\" class=\"sortable\">\r\n    <div align=\"center\">\r\n\t\r\n\t\t\t星期日\r\n\t\t\t\r\n\t</div>\r\n\t</td>\r\n\r\n</tr>\r\n\r\n\r\n\r\n\r\n\r\n\r\n<tr bgcolor=\"#FFFFFF\">\r\n\r\n<td width=\"3%\" rowspan=\"4\">&nbsp;<p class=\"style4\">上午</p></td>\r\n\r\n\r\n\t\t\t  <td width=\"11%\">第1节(08:00-08:45)</td>\r\n\t\t\t \r\n  \r\n    <td>&nbsp;\r\n\r\n     离散数学2_01(校部综合教学1号楼综352)<br>\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n     数据库系统原理_01(西部校区综合教学2号楼B305)<br>\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n  </tr>\r\n\r\n<tr bgcolor=\"#FFFFFF\">\r\n\r\n\r\n\t\t\t  <td width=\"11%\">第2节(08:50-09:35)</td>\r\n\t\t\t \r\n  \r\n    <td>&nbsp;\r\n\r\n     离散数学2_01(校部综合教学1号楼综352)<br>\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n     数据库系统原理_01(西部校区综合教学2号楼B305)<br>\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n  </tr>\r\n\r\n<tr bgcolor=\"#FFFFFF\">\r\n\r\n\r\n\t\t\t  <td width=\"11%\">第3节(10:05-10:50)</td>\r\n\t\t\t \r\n  \r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n     操作系统_02(校部综合教学1号楼综156)<br>\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n     软件工程_01(西部校区综合教学2号楼B305)<br>\r\n\r\n     计算机图形学_01(西部校区综合教学2号楼B305)<br>\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n  </tr>\r\n\r\n<tr bgcolor=\"#FFFFFF\">\r\n\r\n\r\n\t\t\t  <td width=\"11%\">第4节(10:55-11:40)</td>\r\n\t\t\t \r\n  \r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n     操作系统_02(校部综合教学1号楼综156)<br>\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n     软件工程_01(西部校区综合教学2号楼B305)<br>\r\n\r\n     计算机图形学_01(西部校区综合教学2号楼B305)<br>\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n<tr bgcolor=\"#FFFFFF\">\r\n    <td colspan=\"9\">&nbsp;<p align=\"center\" class=\"td2 style5\"><strong>午 休</strong></p></td>\r\n</tr>\r\n\r\n  </tr>\r\n\r\n<tr bgcolor=\"#FFFFFF\">\r\n\r\n<td width=\"3%\" rowspan=\"4\">&nbsp;<p class=\"style4\">下午</p></td>\r\n\r\n\r\n\t\t\t  <td width=\"11%\">第5节(13:30-14:15)</td>\r\n\t\t\t \r\n  \r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n     数据库系统原理_01(西部校区综合教学2号楼B305)<br>\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n     离散数学2_01(校部综合教学1号楼综352)<br>\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n     操作系统_02(校部综合教学1号楼综156)<br>\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n     大学物理A2_500(校部综合教学1号楼综153)<br>\r\n\r\n</td>\r\n\r\n  </tr>\r\n\r\n<tr bgcolor=\"#FFFFFF\">\r\n\r\n\r\n\t\t\t  <td width=\"11%\">第6节(14:20-15:05)</td>\r\n\t\t\t \r\n  \r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n     数据库系统原理_01(西部校区综合教学2号楼B305)<br>\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n     离散数学2_01(校部综合教学1号楼综352)<br>\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n     操作系统_02(校部综合教学1号楼综156)<br>\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n     大学物理A2_500(校部综合教学1号楼综153)<br>\r\n\r\n</td>\r\n\r\n  </tr>\r\n\r\n<tr bgcolor=\"#FFFFFF\">\r\n\r\n\r\n\t\t\t  <td width=\"11%\">第7节(15:35-16:20)</td>\r\n\t\t\t \r\n  \r\n    <td>&nbsp;\r\n\r\n     软件工程_01(西部校区综合教学2号楼B305)<br>\r\n\r\n     计算机图形学_01(西部校区综合教学2号楼B305)<br>\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n     大学物理A2_500(校部综合教学1号楼综153)<br>\r\n\r\n</td>\r\n\r\n  </tr>\r\n\r\n<tr bgcolor=\"#FFFFFF\">\r\n\r\n\r\n\t\t\t  <td width=\"11%\">第8节(16:25-17:10)</td>\r\n\t\t\t \r\n  \r\n    <td>&nbsp;\r\n\r\n     软件工程_01(西部校区综合教学2号楼B305)<br>\r\n\r\n     计算机图形学_01(西部校区综合教学2号楼B305)<br>\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n     大学物理A2_500(校部综合教学1号楼综153)<br>\r\n\r\n</td>\r\n\r\n<tr bgcolor=\"#FFFFFF\">\r\n    <td colspan=\"9\">&nbsp;<p align=\"center\" class=\"td2 style5\"><strong>晚 饭</strong></p></td>\r\n</tr>\r\n\r\n  </tr>\r\n\r\n<tr bgcolor=\"#FFFFFF\">\r\n\r\n<td width=\"3%\" rowspan=\"4\">&nbsp;<p class=\"style4\">晚上</p></td>\r\n\r\n\r\n\t\t\t  <td width=\"11%\">第9节(18:00-18:45)</td>\r\n\t\t\t \r\n  \r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n  </tr>\r\n\r\n<tr bgcolor=\"#FFFFFF\">\r\n\r\n\r\n\t\t\t  <td width=\"11%\">第10节(18:55-19:40)</td>\r\n\t\t\t \r\n  \r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n  </tr>\r\n\r\n<tr bgcolor=\"#FFFFFF\">\r\n\r\n\r\n\t\t\t  <td width=\"11%\">第11节(19:50-20:35)</td>\r\n\t\t\t \r\n  \r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n  </tr>\r\n\r\n<tr bgcolor=\"#FFFFFF\">\r\n\r\n\r\n\t\t\t  <td width=\"11%\">第12节(20:45-21:30)</td>\r\n\t\t\t \r\n  \r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n    <td>&nbsp;\r\n\r\n&nbsp;\r\n\r\n</td>\r\n\r\n  </tr>\r\n\r\n</table>\r\n</td>\r\n</tr>\r\n</table>\r\n\r\n<!--\r\n\r\n\r\n\r\n\r\n\r\n<script type=\"text/javascript\">\r\n  function dy(){\r\n    var today = new Date();\r\n   var timeStr = today.format(\"YYYY年MM月dd日hh小时mm分ss秒\");\r\n   var time = document.getElementById(\"xssj\");\r\n   time.innerHTML=timeStr;\r\n   beforedy();\r\n   document.execCommand(\"print\");\r\n   afterdy();\r\n  }\r\n  Date.prototype.format = function(format){\r\n\t var o = {\r\n\t \"Y+\" :  this.getFullYear(), \r\n\t  \"M+\" :  this.getMonth()+1,  //month\r\n\t  \"d+\" :  this.getDate(),     //day\r\n\t  \"h+\" :  this.getHours(),    //hour\r\n\t      \"m+\" :  this.getMinutes(),  //minute\r\n\t      \"s+\" :  this.getSeconds(), //second\r\n\t      \"q+\" :  Math.floor((this.getMonth()+3)/3),  //quarter\r\n\t      \"S\"  :  this.getMilliseconds() //millisecond\r\n\t   }\r\n\t   if(/(y+)/.test(format)) {\r\n\t    format = format.replace(RegExp.$1, (this.getFullYear()+\"\").substr(4 - RegExp.$1.length));\r\n\t   }\r\n\t \r\n\t   for(var k in o) {\r\n\t    if(new RegExp(\"(\"+ k +\")\").test(format)) {\r\n\t      format = format.replace(RegExp.$1, RegExp.$1.length==1 ? o[k] : (\"00\"+ o[k]).substr((\"\"+ o[k]).length));\r\n\t    }\r\n\t   }\r\n\t return format;\r\n}\r\n  function beforedy(){\r\n    document.getElementById(\"tblHead\").style.display=\"none\";\r\n\t\r\n  var  yhlbss =  document.getElementById(\"yhlb\").value; \r\n   if(\"01\"== yhlbss){\r\n    document.getElementById(\"xsxx\").style.display=\"\";\r\n    document.getElementById(\"kbxx\").style.display=\"none\";\r\n   }\r\n    //document.getElementById(\"xsxx\").style.display=\"\";  //cxl\r\n    //document.getElementById(\"kbxx\").style.display=\"none\"; //cxl\r\n\t\r\n  }\r\n  function afterdy(){\r\n    document.getElementById(\"tblHead\").style.display=\"\";\r\n     var  yhlbss =  document.getElementById(\"yhlb\").value; \r\n   if(\"01\"== yhlbss){\r\n     document.getElementById(\"xsxx\").style.display=\"none\"; \r\n     document.getElementById(\"kbxx\").style.display=\"\";\r\n\t document.getElementById(\"kclist\").style.display=\"\";\r\n   }\r\n   \r\n   \r\n   \r\n\t\r\n  }\r\n</script>\r\n\r\n\r\n<table width=\"100%\" border=\"0\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\">\r\n<tr><td class=\"Linetop\"></td>\r\n</tr>\r\n</table>\r\n     \r\n<input id=\"yhlb\" type=\"hidden\" name=\"yhlb\" size=\"15\" value=\"01\" style=\"width: 50px;\" />\r\n<table width=\"100%\"  border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"title\" id=\"tblHead\">\r\n <tr>\r\n  <td>\r\n   <table border=\"0\" width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" >\r\n   <tr>\r\n   <td width=\"50%\" align=\"left\" valign=\"middle\">&nbsp;<b>选课结果列表</b>&nbsp;</td>\r\n\r\n<td width=\"50%\" align=\"right\">\r\n\r\n</td>\r\n\r\n</tr>\r\n   </table>\r\n  </tr>\r\n</table>\r\n<table width=\"100%\" border=\"0\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\"  >\r\n <tr>\r\n  <td class=\"Linetop\"></td>\r\n </tr>\r\n</table>\r\n\r\n\r\n-->\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n<link href=\"/css/newcss/project.css\" rel=\"stylesheet\" type=\"text/css\">\r\n \r\n\r\n\r\n\r\n<table width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"titleTop2\">\r\n\t\t\t\t\t <tr>\r\n\t\t\t\t\t  <td class=\"pageAlign\">\r\n\t\t\t\t\t   <table cellpadding=\"0\" width=\"100%\" class=\"displayTag\" cellspacing=\"1\" border=\"0\" id=\"user\">\r\n\t\t\t\t\t    <thead>\r\n\t\t\t\t\t\t\t<tr>\r\n\r\n\r\n\r\n\r\n\r\n\r\n<th align=\"center\" width=\"100\" class=\"sortable\">&nbsp;培养方案</th>\r\n\r\n\r\n\r\n\r\n<th align=\"center\" width=\"100\" class=\"sortable\">&nbsp;课程号</th>\r\n\r\n\r\n\r\n\r\n<th align=\"center\" width=\"100\" class=\"sortable\">&nbsp;课程名</th>\r\n\r\n\r\n\r\n\r\n<th align=\"center\" width=\"100\" class=\"sortable\">&nbsp;课序号</th>\r\n\r\n\r\n\r\n\r\n<th align=\"center\" width=\"100\" class=\"sortable\">&nbsp;学分</th>\r\n\r\n\r\n\r\n\r\n<th align=\"center\" width=\"100\" class=\"sortable\">&nbsp;课程属性</th>\r\n\r\n\r\n\r\n\r\n<th align=\"center\" width=\"100\" class=\"sortable\">&nbsp;考试类型</th>\r\n\r\n\r\n\r\n\r\n<th align=\"center\" width=\"100\" class=\"sortable\">&nbsp;教师</th>\r\n\r\n\r\n\r\n\r\n<th align=\"center\" width=\"100\" class=\"sortable\">&nbsp;大纲日历</th>\r\n\r\n\r\n\r\n\r\n<th align=\"center\" width=\"100\" class=\"sortable\">&nbsp;修读方式</th>\r\n\r\n\r\n\r\n\r\n<th align=\"center\" width=\"100\" class=\"sortable\">&nbsp;选课状态</th>\r\n\r\n\r\n\r\n\r\n<th align=\"center\" width=\"100\" class=\"sortable\">&nbsp;周次</th>\r\n\r\n\r\n\r\n\r\n<th align=\"center\" width=\"100\" class=\"sortable\">&nbsp;星期</th>\r\n\r\n\r\n\r\n\r\n<th align=\"center\" width=\"100\" class=\"sortable\">&nbsp;节次</th>\r\n\r\n\r\n\r\n\r\n<th align=\"center\" width=\"100\" class=\"sortable\">&nbsp;节数</th>\r\n\r\n\r\n\r\n\r\n<th align=\"center\" width=\"100\" class=\"sortable\">&nbsp;校区</th>\r\n\r\n\r\n\r\n\r\n<th align=\"center\" width=\"100\" class=\"sortable\">&nbsp;教学楼</th>\r\n\r\n\r\n\r\n\r\n<th align=\"center\" width=\"100\" class=\"sortable\">&nbsp;教室</th>\r\n\r\n\r\n</tr>\r\n</thead>\r\n\r\n\r\n\r\n<tr class=\"odd\" onMouseOut=\"this.className='even';\" onMouseOver=\"this.className='evenfocus';\">\r\n\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;2015级计算机科学与技术培养方案</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;1020640610</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;操作系统实验</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;01</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;1.0</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;必修</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;杨志豪* 李建明 </td>\r\n\r\n\r\n\t\t<td align=\"center\">\r\n\t<img src=\"/img/icon/calendar.jpg\" style=\"cursor: hand;\" title=\"大纲日历\" onclick=\"CxJxDgRl(this)\" name=\"actionType=6&oper=QueryDgRl&kch=1020640610&kxh=01\"></td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;正常</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;选中</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n\r\n<tr class=\"odd\" onMouseOut=\"this.className='even';\" onMouseOver=\"this.className='evenfocus';\">\r\n\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;2015级计算机科学与技术培养方案</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;1020640710</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;编译原理课程设计</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;01</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;1.0</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;必修</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;姚卫红* </td>\r\n\r\n\r\n\t\t<td align=\"center\">\r\n\t<img src=\"/img/icon/calendar.jpg\" style=\"cursor: hand;\" title=\"大纲日历\" onclick=\"CxJxDgRl(this)\" name=\"actionType=6&oper=QueryDgRl&kch=1020640710&kxh=01\"></td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;正常</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;选中</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n\r\n<tr class=\"odd\" onMouseOut=\"this.className='even';\" onMouseOver=\"this.className='evenfocus';\">\r\n\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;2015级计算机科学与技术培养方案</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;1020640800</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;软件工程</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;01</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;2.0</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;必修</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;王凡* </td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" align=\"center\">\r\n\t<img src=\"/img/icon/calendar.jpg\" style=\"cursor: hand;\" title=\"大纲日历\" onclick=\"CxJxDgRl(this)\" name=\"actionType=6&oper=QueryDgRl&kch=1020640800&kxh=01\"></td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;正常</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;选中</td>\r\n\r\n\r\n\r\n\r\n<td>&nbsp; 9-16周上</td>\r\n\r\n<td>&nbsp; 1</td>\r\n\r\n\t\t\t  <td>&nbsp;7</td>\r\n\t\t\t \r\n<td>&nbsp; 2</td>\r\n\r\n<td>&nbsp; 西部校区</td>\r\n\r\n<td>&nbsp; 综合教学2号楼</td>\r\n\r\n<td>&nbsp; B305</td>\r\n\r\n</tr>\r\n\r\n\r\n<tr class=odd onMouseOut=this.className='even'; onMouseOver=this.className='evenfocus';>\r\n\r\n<td>&nbsp; 9-16周上</td>\r\n\r\n<td>&nbsp; 4</td>\r\n\r\n\t\t\t  <td>&nbsp;3</td>\r\n\t\t\t \r\n<td>&nbsp; 2</td>\r\n\r\n<td>&nbsp; 西部校区</td>\r\n\r\n<td>&nbsp; 综合教学2号楼</td>\r\n\r\n<td>&nbsp; B305</td>\r\n\r\n</tr>\r\n\r\n\r\n<tr class=\"odd\" onMouseOut=\"this.className='even';\" onMouseOver=\"this.className='evenfocus';\">\r\n\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;2015级计算机科学与技术培养方案</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;1020641020</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;计算机图形学</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;01</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;2.0</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;选修</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;周东清* </td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" align=\"center\">\r\n\t<img src=\"/img/icon/calendar.jpg\" style=\"cursor: hand;\" title=\"大纲日历\" onclick=\"CxJxDgRl(this)\" name=\"actionType=6&oper=QueryDgRl&kch=1020641020&kxh=01\"></td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;正常</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;选中</td>\r\n\r\n\r\n\r\n\r\n<td>&nbsp; 1-8周上</td>\r\n\r\n<td>&nbsp; 4</td>\r\n\r\n\t\t\t  <td>&nbsp;3</td>\r\n\t\t\t \r\n<td>&nbsp; 2</td>\r\n\r\n<td>&nbsp; 西部校区</td>\r\n\r\n<td>&nbsp; 综合教学2号楼</td>\r\n\r\n<td>&nbsp; B305</td>\r\n\r\n</tr>\r\n\r\n\r\n<tr class=odd onMouseOut=this.className='even'; onMouseOver=this.className='evenfocus';>\r\n\r\n<td>&nbsp; 1-8周上</td>\r\n\r\n<td>&nbsp; 1</td>\r\n\r\n\t\t\t  <td>&nbsp;7</td>\r\n\t\t\t \r\n<td>&nbsp; 2</td>\r\n\r\n<td>&nbsp; 西部校区</td>\r\n\r\n<td>&nbsp; 综合教学2号楼</td>\r\n\r\n<td>&nbsp; B305</td>\r\n\r\n</tr>\r\n\r\n\r\n<tr class=\"odd\" onMouseOut=\"this.className='even';\" onMouseOver=\"this.className='evenfocus';\">\r\n\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;2015级计算机科学与技术培养方案</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;1020640210</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;离散数学2</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;01</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;2.5</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;必修</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;李丽双* </td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" align=\"center\">\r\n\t<img src=\"/img/icon/calendar.jpg\" style=\"cursor: hand;\" title=\"大纲日历\" onclick=\"CxJxDgRl(this)\" name=\"actionType=6&oper=QueryDgRl&kch=1020640210&kxh=01\"></td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;复修</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;选中</td>\r\n\r\n\r\n\r\n\r\n<td>&nbsp; 7-16周上</td>\r\n\r\n<td>&nbsp; 1</td>\r\n\r\n\t\t\t  <td>&nbsp;1</td>\r\n\t\t\t \r\n<td>&nbsp; 2</td>\r\n\r\n<td>&nbsp; 校部</td>\r\n\r\n<td>&nbsp; 综合教学1号楼</td>\r\n\r\n<td>&nbsp; 综352</td>\r\n\r\n</tr>\r\n\r\n\r\n<tr class=odd onMouseOut=this.className='even'; onMouseOver=this.className='evenfocus';>\r\n\r\n<td>&nbsp; 7-16周上</td>\r\n\r\n<td>&nbsp; 4</td>\r\n\r\n\t\t\t  <td>&nbsp;5</td>\r\n\t\t\t \r\n<td>&nbsp; 2</td>\r\n\r\n<td>&nbsp; 校部</td>\r\n\r\n<td>&nbsp; 综合教学1号楼</td>\r\n\r\n<td>&nbsp; 综352</td>\r\n\r\n</tr>\r\n\r\n\r\n<tr class=\"odd\" onMouseOut=\"this.className='even';\" onMouseOver=\"this.className='evenfocus';\">\r\n\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;2015级计算机科学与技术培养方案</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;1020640020</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;数据库系统原理</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;01</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;3.0</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;必修</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;唐达* </td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" align=\"center\">\r\n\t<img src=\"/img/icon/calendar.jpg\" style=\"cursor: hand;\" title=\"大纲日历\" onclick=\"CxJxDgRl(this)\" name=\"actionType=6&oper=QueryDgRl&kch=1020640020&kxh=01\"></td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;正常</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;选中</td>\r\n\r\n\r\n\r\n\r\n<td>&nbsp; 1-10周上</td>\r\n\r\n<td>&nbsp; 2</td>\r\n\r\n\t\t\t  <td>&nbsp;5</td>\r\n\t\t\t \r\n<td>&nbsp; 2</td>\r\n\r\n<td>&nbsp; 西部校区</td>\r\n\r\n<td>&nbsp; 综合教学2号楼</td>\r\n\r\n<td>&nbsp; B305</td>\r\n\r\n</tr>\r\n\r\n\r\n<tr class=odd onMouseOut=this.className='even'; onMouseOver=this.className='evenfocus';>\r\n\r\n<td>&nbsp; 1-10周上</td>\r\n\r\n<td>&nbsp; 5</td>\r\n\r\n\t\t\t  <td>&nbsp;1</td>\r\n\t\t\t \r\n<td>&nbsp; 2</td>\r\n\r\n<td>&nbsp; 西部校区</td>\r\n\r\n<td>&nbsp; 综合教学2号楼</td>\r\n\r\n<td>&nbsp; B305</td>\r\n\r\n</tr>\r\n\r\n\r\n<tr class=\"odd\" onMouseOut=\"this.className='even';\" onMouseOver=\"this.className='evenfocus';\">\r\n\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;2015级计算机科学与技术培养方案</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;1020640510</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;计算机网络实验</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;01</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;2.0</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;必修</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;许侃* 董校 </td>\r\n\r\n\r\n\t\t<td align=\"center\">\r\n\t<img src=\"/img/icon/calendar.jpg\" style=\"cursor: hand;\" title=\"大纲日历\" onclick=\"CxJxDgRl(this)\" name=\"actionType=6&oper=QueryDgRl&kch=1020640510&kxh=01\"></td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;正常</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;选中</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n\r\n<tr class=\"odd\" onMouseOut=\"this.className='even';\" onMouseOver=\"this.className='evenfocus';\">\r\n\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;2015级计算机科学与技术培养方案</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;1020640600</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;操作系统</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;02</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;3.5</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;必修</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;李建明* </td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" align=\"center\">\r\n\t<img src=\"/img/icon/calendar.jpg\" style=\"cursor: hand;\" title=\"大纲日历\" onclick=\"CxJxDgRl(this)\" name=\"actionType=6&oper=QueryDgRl&kch=1020640600&kxh=02\"></td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;正常</td>\r\n\r\n\r\n\t\t<td rowspan=\"2\" >\r\n\t&nbsp;选中</td>\r\n\r\n\r\n\r\n\r\n<td>&nbsp; 1-14周上</td>\r\n\r\n<td>&nbsp; 2</td>\r\n\r\n\t\t\t  <td>&nbsp;3</td>\r\n\t\t\t \r\n<td>&nbsp; 2</td>\r\n\r\n<td>&nbsp; 校部</td>\r\n\r\n<td>&nbsp; 综合教学1号楼</td>\r\n\r\n<td>&nbsp; 综156</td>\r\n\r\n</tr>\r\n\r\n\r\n<tr class=odd onMouseOut=this.className='even'; onMouseOver=this.className='evenfocus';>\r\n\r\n<td>&nbsp; 1-14周上</td>\r\n\r\n<td>&nbsp; 5</td>\r\n\r\n\t\t\t  <td>&nbsp;5</td>\r\n\t\t\t \r\n<td>&nbsp; 2</td>\r\n\r\n<td>&nbsp; 校部</td>\r\n\r\n<td>&nbsp; 综合教学1号楼</td>\r\n\r\n<td>&nbsp; 综156</td>\r\n\r\n</tr>\r\n\r\n\r\n<tr class=\"odd\" onMouseOut=\"this.className='even';\" onMouseOver=\"this.className='evenfocus';\">\r\n\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;2015级计算机科学与技术培养方案</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;1190060020</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;社会实践</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;01</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;1.0</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;任选</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;王杨* 王旭 </td>\r\n\r\n\r\n\t\t<td align=\"center\">\r\n\t<img src=\"/img/icon/calendar.jpg\" style=\"cursor: hand;\" title=\"大纲日历\" onclick=\"CxJxDgRl(this)\" name=\"actionType=6&oper=QueryDgRl&kch=1190060020&kxh=01\"></td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;正常</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;选中</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n\r\n<tr class=\"odd\" onMouseOut=\"this.className='even';\" onMouseOver=\"this.className='evenfocus';\">\r\n\r\n\r\n\r\n\t\t<td rowspan=\"1\" >\r\n\t&nbsp;2015级计算机科学与技术培养方案</td>\r\n\r\n\r\n\t\t<td rowspan=\"1\" >\r\n\t&nbsp;1110020020</td>\r\n\r\n\r\n\t\t<td rowspan=\"1\" >\r\n\t&nbsp;大学物理A2</td>\r\n\r\n\r\n\t\t<td rowspan=\"1\" >\r\n\t&nbsp;500</td>\r\n\r\n\r\n\t\t<td rowspan=\"1\" >\r\n\t&nbsp;3.0</td>\r\n\r\n\r\n\t\t<td rowspan=\"1\" >\r\n\t&nbsp;必修</td>\r\n\r\n\r\n\t\t<td rowspan=\"1\" >\r\n\t&nbsp;</td>\r\n\r\n\r\n\t\t<td rowspan=\"1\" >\r\n\t&nbsp;李雪春* </td>\r\n\r\n\r\n\t\t<td rowspan=\"1\" align=\"center\">\r\n\t<img src=\"/img/icon/calendar.jpg\" style=\"cursor: hand;\" title=\"大纲日历\" onclick=\"CxJxDgRl(this)\" name=\"actionType=6&oper=QueryDgRl&kch=1110020020&kxh=500\"></td>\r\n\r\n\r\n\t\t<td rowspan=\"1\" >\r\n\t&nbsp;复修</td>\r\n\r\n\r\n\t\t<td rowspan=\"1\" >\r\n\t&nbsp;选中</td>\r\n\r\n\r\n\r\n\r\n<td>&nbsp; 3-14周上</td>\r\n\r\n<td>&nbsp; 7</td>\r\n\r\n\t\t\t  <td>&nbsp;5</td>\r\n\t\t\t \r\n<td>&nbsp; 4</td>\r\n\r\n<td>&nbsp; 校部</td>\r\n\r\n<td>&nbsp; 综合教学1号楼</td>\r\n\r\n<td>&nbsp; 综153</td>\r\n\r\n</tr>\r\n\r\n\r\n<tr class=\"odd\" onMouseOut=\"this.className='even';\" onMouseOver=\"this.className='evenfocus';\">\r\n\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;2015级计算机科学与技术培养方案</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;1020640060</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;生产实习</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;01</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;1.0</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;必修</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;董校* </td>\r\n\r\n\r\n\t\t<td align=\"center\">\r\n\t<img src=\"/img/icon/calendar.jpg\" style=\"cursor: hand;\" title=\"大纲日历\" onclick=\"CxJxDgRl(this)\" name=\"actionType=6&oper=QueryDgRl&kch=1020640060&kxh=01\"></td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;正常</td>\r\n\r\n\r\n\t\t<td>\r\n\t&nbsp;选中</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n<td>&nbsp;</td>\r\n\r\n</table>\r\n</td>\r\n</tr>\r\n</table>\r\n<Script language=\"JavaScript\">\r\nfunction CxJxDgRl( a){\r\n\twindow.open(\"xkAction.do?\"+a.name);\r\n}\r\n</Script>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n<table width=\"100%\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\">\r\n<tr>\r\n\r\n<td height=\"21\" bgcolor=\"#F2F2F2\"><div align=\"right\">共22.0学分</div></td>\r\n\r\n</tr>\r\n</table>  \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n</body>\r\n</html>\r\n";
            //GetInfo gt = new GetInfo();
            // gt.Analysis();
            SaveToDataBase sv = new SaveToDataBase(testT);
            sv.SaveTodb();

            SqlHelper.CreatDB(@"D:\test.db");
            


        }
       

    }

    

}
