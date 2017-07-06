﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Founders
{
    class RAIDA
    {
        /* INSTANCE VARIABLE */
        public DetectionAgent[] agent;
        public CloudCoin returnCoin;
        public Response[] responseArray = new Response[25];
        private int[] working_triad = { 0, 1, 2 };//place holder
        public bool[] raidaIsDetecting = { true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true };
        public string[] lastDetectStatus = { "notdetected", "notdetected", "notdetected", "notdetected", "notdetected", "notdetected", "notdetected", "notdetected", "notdetected", "notdetected", "notdetected", "notdetected", "notdetected", "notdetected", "notdetected", "notdetected", "notdetected", "notdetected", "notdetected", "notdetected", "notdetected", "notdetected", "notdetected", "notdetected", "notdetected" };
        public string[] echoStatus = { "noreply", "noreply", "noreply", "noreply", "noreply", "noreply", "noreply", "noreply", "noreply", "noreply", "noreply", "noreply", "noreply", "noreply", "noreply", "noreply", "noreply", "noreply", "noreply", "noreply", "noreply", "noreply", "noreply", "noreply", "noreply" };



        /* CONSTRUCTOR */
        public RAIDA(int milliSecondsToTimeOut)
        { //  initialise instance variables
            this.agent = new DetectionAgent[25];
            for (int i = 0; (i < 25); i++)
            {
                this.agent[i] = new DetectionAgent(i, milliSecondsToTimeOut);
            } // end for each Raida
        }//End Constructor


        public void echoOne(int raida_id)
        {
            DetectionAgent da = new DetectionAgent(raida_id, 2000);
            responseArray[raida_id] = da.echo(raida_id);
        }//end echo 




        public Response[] echoAll(int milliSecondsToTimeOut)
        {


            Response[] results = new Response[25];
            var t00 = Task.Factory.StartNew(() => echoOne(00));
            var t01 = Task.Factory.StartNew(() => echoOne(01));
            var t02 = Task.Factory.StartNew(() => echoOne(02));
            var t03 = Task.Factory.StartNew(() => echoOne(03));
            var t04 = Task.Factory.StartNew(() => echoOne(04));
            var t05 = Task.Factory.StartNew(() => echoOne(05));
            var t06 = Task.Factory.StartNew(() => echoOne(06));
            var t07 = Task.Factory.StartNew(() => echoOne(07));
            var t08 = Task.Factory.StartNew(() => echoOne(08));
            var t09 = Task.Factory.StartNew(() => echoOne(09));
            var t10 = Task.Factory.StartNew(() => echoOne(10));
            var t11 = Task.Factory.StartNew(() => echoOne(11));
            var t12 = Task.Factory.StartNew(() => echoOne(12));
            var t13 = Task.Factory.StartNew(() => echoOne(13));
            var t14 = Task.Factory.StartNew(() => echoOne(14));
            var t15 = Task.Factory.StartNew(() => echoOne(15));
            var t16 = Task.Factory.StartNew(() => echoOne(16));
            var t17 = Task.Factory.StartNew(() => echoOne(17));
            var t18 = Task.Factory.StartNew(() => echoOne(18));
            var t19 = Task.Factory.StartNew(() => echoOne(19));
            var t20 = Task.Factory.StartNew(() => echoOne(20));
            var t21 = Task.Factory.StartNew(() => echoOne(21));
            var t22 = Task.Factory.StartNew(() => echoOne(22));
            var t23 = Task.Factory.StartNew(() => echoOne(23));
            var t24 = Task.Factory.StartNew(() => echoOne(24));

            var taskList = new List<Task> { t00, t01, t02, t03, t04, t05, t06, t07, t08, t09, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24 };
            Task.WaitAll(taskList.ToArray(), milliSecondsToTimeOut);
            return results;
        }//end echo



        public void detectOne(int raida_id, int nn, int sn, String an, String pan, int d)
        {
            DetectionAgent da = new DetectionAgent(raida_id, 5000);
            responseArray[raida_id] = da.detect(nn, sn, an, pan, d);
        }//end detectOne



        public CoinUtils detectCoin( CoinUtils cu, int milliSecondsToTimeOut )
        {
            cu.generatePan();

            var t00 = Task.Factory.StartNew(() => detectOne( 00, cu.cc.nn, cu.cc.sn, cu.cc.an[00], cu.pans[00], cu.getDenomination()));
            var t01 = Task.Factory.StartNew(() => detectOne( 01, cu.cc.nn, cu.cc.sn, cu.cc.an[01], cu.pans[01], cu.getDenomination()));
            var t02 = Task.Factory.StartNew(() => detectOne( 02, cu.cc.nn, cu.cc.sn, cu.cc.an[02], cu.pans[02], cu.getDenomination()));
            var t03 = Task.Factory.StartNew(() => detectOne( 03, cu.cc.nn, cu.cc.sn, cu.cc.an[03], cu.pans[03], cu.getDenomination()));
            var t04 = Task.Factory.StartNew(() => detectOne( 04, cu.cc.nn, cu.cc.sn, cu.cc.an[04], cu.pans[04], cu.getDenomination()));
            var t05 = Task.Factory.StartNew(() => detectOne( 05, cu.cc.nn, cu.cc.sn, cu.cc.an[05], cu.pans[05], cu.getDenomination()));
            var t06 = Task.Factory.StartNew(() => detectOne( 06, cu.cc.nn, cu.cc.sn, cu.cc.an[06], cu.pans[06], cu.getDenomination()));
            var t07 = Task.Factory.StartNew(() => detectOne( 07, cu.cc.nn, cu.cc.sn, cu.cc.an[07], cu.pans[07], cu.getDenomination()));
            var t08 = Task.Factory.StartNew(() => detectOne( 08, cu.cc.nn, cu.cc.sn, cu.cc.an[08], cu.pans[08], cu.getDenomination()));
            var t09 = Task.Factory.StartNew(() => detectOne( 09, cu.cc.nn, cu.cc.sn, cu.cc.an[09], cu.pans[09], cu.getDenomination()));
            var t10 = Task.Factory.StartNew(() => detectOne( 10, cu.cc.nn, cu.cc.sn, cu.cc.an[10], cu.pans[10], cu.getDenomination()));
            var t11 = Task.Factory.StartNew(() => detectOne( 11, cu.cc.nn, cu.cc.sn, cu.cc.an[11], cu.pans[11], cu.getDenomination()));
            var t12 = Task.Factory.StartNew(() => detectOne( 12, cu.cc.nn, cu.cc.sn, cu.cc.an[12], cu.pans[12], cu.getDenomination()));
            var t13 = Task.Factory.StartNew(() => detectOne( 13, cu.cc.nn, cu.cc.sn, cu.cc.an[13], cu.pans[13], cu.getDenomination()));
            var t14 = Task.Factory.StartNew(() => detectOne( 14, cu.cc.nn, cu.cc.sn, cu.cc.an[14], cu.pans[14], cu.getDenomination()));
            var t15 = Task.Factory.StartNew(() => detectOne( 15, cu.cc.nn, cu.cc.sn, cu.cc.an[15], cu.pans[15], cu.getDenomination()));
            var t16 = Task.Factory.StartNew(() => detectOne( 16, cu.cc.nn, cu.cc.sn, cu.cc.an[16], cu.pans[16], cu.getDenomination()));
            var t17 = Task.Factory.StartNew(() => detectOne( 17, cu.cc.nn, cu.cc.sn, cu.cc.an[17], cu.pans[17], cu.getDenomination()));
            var t18 = Task.Factory.StartNew(() => detectOne( 18, cu.cc.nn, cu.cc.sn, cu.cc.an[18], cu.pans[18], cu.getDenomination()));
            var t19 = Task.Factory.StartNew(() => detectOne( 19, cu.cc.nn, cu.cc.sn, cu.cc.an[19], cu.pans[19], cu.getDenomination()));
            var t20 = Task.Factory.StartNew(() => detectOne( 20, cu.cc.nn, cu.cc.sn, cu.cc.an[20], cu.pans[20], cu.getDenomination()));
            var t21 = Task.Factory.StartNew(() => detectOne( 21, cu.cc.nn, cu.cc.sn, cu.cc.an[21], cu.pans[21], cu.getDenomination()));
            var t22 = Task.Factory.StartNew(() => detectOne( 22, cu.cc.nn, cu.cc.sn, cu.cc.an[22], cu.pans[22], cu.getDenomination()));
            var t23 = Task.Factory.StartNew(() => detectOne( 23, cu.cc.nn, cu.cc.sn, cu.cc.an[23], cu.pans[23], cu.getDenomination()));
            var t24 = Task.Factory.StartNew(() => detectOne( 24, cu.cc.nn, cu.cc.sn, cu.cc.an[24], cu.pans[24], cu.getDenomination()));


            var taskList = new List<Task> { t00, t01, t02, t03, t04, t05, t06, t07, t08, t09, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24 };
            Task.WaitAll(taskList.ToArray(), milliSecondsToTimeOut);
            //Get data from the detection agents

            for (int i = 0; i < 25; i++)
            {
                if (responseArray[i] != null)
                {
                    cu.setPastStatus(responseArray[i].outcome, i);
                }
                else
                {
                    cu.setPastStatus("undetected", i);
                };// should be pass, fail, error or undetected. 
            }//end for each detection agent

            cu.setAnsToPansIfPassed();
            cu.calculateHP();
            cu.gradeCoin(); // sets the grade and figures out what the file extension should be (bank, fracked, counterfeit, lost
            cu.calcExpirationDate();
            cu.grade();
         
            return cu;
        }//end detect coin


        public void get_Ticket(int i, int raidaID, int nn, int sn, String an, int d)
        {
            DetectionAgent da = new DetectionAgent(raidaID, 5000);
            responseArray[raidaID] = da.get_ticket(nn, sn, an, d);
        }//end get ticket


        public void get_Tickets(int[] triad, String[] ans, int nn, int sn, int denomination, int milliSecondsToTimeOut)
        {
            //Console.WriteLine("Get Tickets called. ");
            var t00 = Task.Factory.StartNew(() => get_Ticket(0, triad[00], nn, sn, ans[00], denomination));
            var t01 = Task.Factory.StartNew(() => get_Ticket(1, triad[01], nn, sn, ans[01], denomination));
            var t02 = Task.Factory.StartNew(() => get_Ticket(2, triad[02], nn, sn, ans[02], denomination));

            var taskList = new List<Task> { t00, t01, t02 };
            Task.WaitAll(taskList.ToArray(), milliSecondsToTimeOut);
            //Get data from the detection agents
        }//end detect coin



    }//end RAIDA Class
}// End Namespace
