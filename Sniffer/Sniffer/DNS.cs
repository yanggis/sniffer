﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sniffer
{
    class DNS
    {
        public Dictionary<string, string> application_info;
        public string info;

        /// <summary>
        /// 构造函数
        /// </summary>
        public DNS(byte[] dns_byte_data, string detail_protocol = "DNS")
        {
            this.application_info = new Dictionary<string, string>();
            var dnsdata = dns_byte_data;            

            this.application_info.Add("ApplicationType", detail_protocol);
            this.application_info.Add("Transaction ID", "0x" + Convert.ToString(dnsdata[0], 16).ToUpper().PadLeft(2, '0') + Convert.ToString(dnsdata[1], 16).ToUpper().PadLeft(2, '0'));
            this.application_info.Add("QR", ((dnsdata[2] & 128) >> 7).ToString());
            this.application_info.Add("opcode", ((dnsdata[2] & 120) >> 3).ToString());
            this.application_info.Add("AA", ((dnsdata[2] & 4) >> 2).ToString());
            this.application_info.Add("TC", ((dnsdata[2] & 2) >> 1).ToString());
            this.application_info.Add("RD", (dnsdata[2] & 1).ToString());
            this.application_info.Add("RA", ((dnsdata[3] & 128) >> 7).ToString());
            this.application_info.Add("zero", ((dnsdata[3] & 112) >> 4).ToString());
            this.application_info.Add("rcode", (dnsdata[3] & 15).ToString());
            this.application_info.Add("Questions", ((dnsdata[4] << 8) + dnsdata[5]).ToString());
            this.application_info.Add("Answer RRs", ((dnsdata[6] << 8) + dnsdata[7]).ToString());
            this.application_info.Add("Authority RRs", ((dnsdata[8] << 8) + dnsdata[9]).ToString());
            this.application_info.Add("Additional RRs", ((dnsdata[10] << 8) + dnsdata[11]).ToString());

            if (dnsdata.Length > 12)
            {
                int offset = 12;
                int labelLen;
                string Queries_result = "";
                string Answers_result = "";
                string Authoritative_result = "";
                string Additional_result = "";
                for (int i = 0; i < int.Parse(this.application_info["Questions"]); i++)
                {
                    //查询名
                    string name = GetLabelName(dnsdata, offset, out labelLen);
                    offset += labelLen;
                    //查询类型
                    offset++;
                    string Type = ((dnsdata[offset++] << 8) + dnsdata[offset]).ToString();
                    //查询类                                            
                    offset++;
                    string Class = ((dnsdata[offset++] << 8) + dnsdata[offset]).ToString();
                    offset++;
                    Queries_result += "Name: " + name + "\r\n" + "Type: " + type_analysis(Type) + "\r\n" + "Class: " + class_analysis(Class) + "\r\n";
                }
                if (Queries_result.Length > 0)
                {
                    this.application_info.Add("Queries", Queries_result);
                }
                for (int i = 0; i < int.Parse(this.application_info["Answer RRs"]); i++)
                {
                    //域名
                    string name = GetLabelName(dnsdata, offset, out labelLen);
                    offset += labelLen;
                    //类型
                    offset++;
                    string Type = ((dnsdata[offset++] << 8) + dnsdata[offset]).ToString();
                    //类                                            
                    offset++;
                    string Class = ((dnsdata[offset++] << 8) + dnsdata[offset]).ToString();
                    //生存时间
                    offset++;
                    string TTL = ((dnsdata[offset++] << 24) + (dnsdata[offset++] << 16) + (dnsdata[offset++] << 8) + dnsdata[offset]).ToString();
                    //资源数据长度
                    offset++;
                    string Length = ((dnsdata[offset++] << 8) + dnsdata[offset]).ToString();
                    offset++;
                    //数据解析，待完成
                    string data = "";
                    for (int j = 0; j < int.Parse(Length); j++)
                    {
                        data += Convert.ToString(dnsdata[j + offset], 16).ToUpper().PadLeft(2, '0');
                    }
                    Answers_result += "Name: " + name + "\r\n" + "Type: " + type_analysis(Type) + "\r\n" + "Class: " + class_analysis(Class) + "\r\n" + "TTL: " + TTL + "\r\n" + "Data Length: " + Length + "\r\n" + "Data: " + data + "\r\n\r\n";
                    offset += int.Parse(Length);
                }
                if (Answers_result.Length > 0)
                {
                    this.application_info.Add("Answers", Answers_result);
                }
                for (int i = 0; i < int.Parse(this.application_info["Authority RRs"]); i++)
                {
                    //域名
                    string name = GetLabelName(dnsdata, offset, out labelLen);
                    offset += labelLen;
                    //类型
                    offset++;
                    string Type = ((dnsdata[offset++] << 8) + dnsdata[offset]).ToString();
                    //类                                            
                    offset++;
                    string Class = ((dnsdata[offset++] << 8) + dnsdata[offset]).ToString();
                    //生存时间
                    offset++;
                    string TTL = ((dnsdata[offset++] << 24) + (dnsdata[offset++] << 16) + (dnsdata[offset++] << 8) + dnsdata[offset]).ToString();
                    //资源数据长度
                    offset++;
                    string Length = ((dnsdata[offset++] << 8) + dnsdata[offset]).ToString();
                    offset++;
                    //数据解析，待完成
                    string data = "";
                    for (int j = 0; j < int.Parse(Length); j++)
                    {
                        data += Convert.ToString(dnsdata[j + offset], 16).ToUpper().PadLeft(2, '0');
                    }
                    Authoritative_result += "Name: " + name + "\r\n" + "Type: " + type_analysis(Type) + "\r\n" + "Class: " + class_analysis(Class) + "\r\n" + "TTL: " + TTL + "\r\n" + "Data Length: " + Length + "\r\n" + "Data: " + data + "\r\n\r\n";
                    offset += int.Parse(Length);
                }
                if (Authoritative_result.Length > 0)
                {
                    this.application_info.Add("Authoritative nameservers", Authoritative_result);
                }
                for (int i = 0; i < int.Parse(this.application_info["Additional RRs"]); i++)
                {
                    //域名
                    string name = GetLabelName(dnsdata, offset, out labelLen);
                    offset += labelLen;
                    //类型
                    offset++;
                    string Type = ((dnsdata[offset++] << 8) + dnsdata[offset]).ToString();
                    //类                                            
                    offset++;
                    string Class = ((dnsdata[offset++] << 8) + dnsdata[offset]).ToString();
                    //生存时间
                    offset++;
                    string TTL = ((dnsdata[offset++] << 24) + (dnsdata[offset++] << 16) + (dnsdata[offset++] << 8) + dnsdata[offset]).ToString();
                    //资源数据长度
                    offset++;
                    string Length = ((dnsdata[offset++] << 8) + dnsdata[offset]).ToString();
                    offset++;
                    //数据解析，待完成
                    string data = "";
                    for (int j = 0; j < int.Parse(Length); j++)
                    {
                        data += Convert.ToString(dnsdata[j + offset], 16).ToUpper().PadLeft(2, '0');
                    }
                    Additional_result += "Name: " + name + "\r\n" + "Type: " + type_analysis(Type) + "\r\n" + "Class: " + class_analysis(Class) + "\r\n" + "TTL: " + TTL + "\r\n" + "Data Length: " + Length + "\r\n" + "Data: " + data + "\r\n\r\n";
                    offset += int.Parse(Length);
                }
                if (Additional_result.Length > 0)
                {
                    this.application_info.Add("Additional records", Additional_result);
                }
            }

            if (this.application_info["opcode"] == "0")
            {
                if (detail_protocol == "DNS" || detail_protocol == "LLMNR" || detail_protocol == "MDNS")
                {
                    this.info = "Standard query " + (this.application_info["QR"] == "1" ? "response " : "") + this.application_info["Transaction ID"];
                }
                else if (detail_protocol == "NBNS")
                {
                    this.info = "Name query";
                }
                else
                {
                    this.info = "to be continued";
                }
            }
            else if (this.application_info["opcode"] == "5")
            {
                if (detail_protocol == "DNS" || detail_protocol == "LLMNR" || detail_protocol == "MDNS")
                {
                    this.info = "to be continued";
                }
                else if (detail_protocol == "NBNS")
                {
                    this.info = "Registration";
                }
                else
                {
                    this.info = "to be continued";
                }
            }
            else
            {
                this.info = "DNS to be continued";
            }
        }

        /// <summary>
        /// DNS域名解析
        /// </summary>
        public static string GetLabelName(byte[] data, int offset, out int labelLen)
        {
            bool alreadyJump = false;
            int seek = offset;
            int len = data[seek];
            labelLen = 0;
            StringBuilder result = new StringBuilder(63);
            while (len > 0 && seek < data.Length)
            {
                if (len > 191 && len < 255)
                {
                    if (alreadyJump)
                    {
                        labelLen = seek - offset;
                        return result.ToString();
                    }
                    int tempLen;
                    result.Append(GetLabelName(data, data[++seek] + (len - 192) * 256, out tempLen));
                    alreadyJump = true;
                    labelLen = seek - offset;
                    return result.ToString();
                }
                else if (len < 64)
                {
                    for (; len > 0; len--)
                    {
                        result.Append((char)data[++seek]);
                    }
                    len = data[++seek];
                    if (len > 0) result.Append(".");
                }
            }
            labelLen = seek - offset;
            return result.ToString();
        }
        /// <summary>
        /// Type解析
        /// </summary>
        public string type_analysis(string type)
        {
            switch (type)
            { 
                case "1":
                    return "A";
                case "2":
                    return "NS";
                case "3":
                    return "MD";
                case "4":
                    return "MF";
                case "5":
                    return "CNAME";
                case "6":
                    return "SOA";
                case "7":
                    return "MB";
                case "8":
                    return "MG";
                case "9":
                    return "MR";
                case "10":
                    return "NULL";
                case "11":
                    return "WKS";
                case "12":
                    return "PTR";
                case "13":
                    return "HINFO";
                case "14":
                    return "MINFO";
                case "15":
                    return "MX";
                case "16":
                    return "TXT";
                case "28":
                    return "AAAA";
                case "32":
                    return "NB";
                case "41":
                    return "OPT";
                case "100":
                    return "UINFO";
                case "101":
                    return "UID";
                case "102":
                    return "GID";
                case "255":
                    return "ANY";
                default:                    
                    return "UNKOWN";
            }
        }
        /// <summary>
        /// Class解析
        /// </summary>
        public string class_analysis(string class_int)
        {
            switch (class_int)
            {
                case "1":
                    return "IN";
                case "2":
                    return "CSNET";
                case "3":
                    return "CHAOS";
                case "4":
                    return "HESIOD";
                case "255":
                    return "ANY";
                default:
                    return "UNKOWN";
            }
        }
    }
}
