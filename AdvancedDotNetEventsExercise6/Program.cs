// See https://aka.ms/new-console-template for more information

using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Xsl;
using System;

Phone police = new Phone("101");
Phone firefighters = new Phone("112");

var phoneNetwork = new PhoneNetwork();

phoneNetwork.AddPhoneToNetwork(police);
phoneNetwork.AddPhoneToNetwork(firefighters);

phoneNetwork.CallPhone(101);
phoneNetwork.CallPhone(112);

phoneNetwork.SendMessageToPhone(101 , "Help");
phoneNetwork.SendMessageToPhone(101 , "SOS");
phoneNetwork.SendMessageToPhone(100 , "Are you comming?");
phoneNetwork.SendMessageToPhone(112 , "The roof is on fire");
