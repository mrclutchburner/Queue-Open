package antsoft.client;

import eneter.messaging.diagnostic.EneterTrace;
import eneter.messaging.endpoints.typedmessages.*;
import eneter.messaging.messagingsystems.messagingsystembase.*;
import eneter.messaging.messagingsystems.tcpmessagingsystem.TcpMessagingSystemFactory;
import eneter.messaging.messagingsystems.tcpmessagingsystem.TcpPolicyServer;
import eneter.messaging.messagingsystems.threadmessagingsystem.ThreadMessagingSystemFactory;
import eneter.messaging.messagingsystems.threadpoolmessagingsystem.ThreadPoolMessagingSystemFactory;
import eneter.messaging.nodes.channelwrapper.*;
import eneter.net.system.EventHandler;
import eneter.messaging.diagnostic.EneterTrace;
import eneter.messaging.endpoints.typedmessages.*;
import eneter.messaging.messagingsystems.messagingsystembase.*;
import eneter.messaging.messagingsystems.tcpmessagingsystem.*;
import eneter.net.system.EventHandler;
import android.app.Activity;
import android.app.AlertDialog;
import android.app.Dialog;
import android.app.DialogFragment;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.pm.ActivityInfo;
import android.content.res.Configuration;
import android.drm.DrmStore;
import android.graphics.Color;
import android.graphics.drawable.AnimationDrawable;
import android.os.Bundle;
import android.os.CountDownTimer;
import android.os.Handler;
import android.text.method.PasswordTransformationMethod;
import android.util.SparseBooleanArray;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.WindowManager;
import android.view.animation.AlphaAnimation;
import android.view.animation.Animation;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.ImageView;
import android.widget.Toast;
import android.widget .*;
import android.app.Activity;
//import android.conten.*;

import java.io.BufferedReader;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import android.animation.ArgbEvaluator;
import android.animation.ObjectAnimator;
import android.animation.ValueAnimator;
public class main_class extends Activity
{
    // Input data
    public static class DataInput
    {
        public Integer ID=1;
        public Integer Nomor=1;
        public Integer Layanan=1;
        public Integer Loket=1;
        public Integer SID=1;
        public Integer LayananLoket=1;
        public Integer SisaNomor=0;
        public Integer LayananTujuan=0;
        public Integer TotalTransaksi=1;
        public String BatasBawah="00:00:01";
        public String BatasAtas="23:59:00";
        public String Command="Call";
        public String CounterName="Counter 1";
        public Integer Counter=1;
        public String User="Admin";
        public String Confrim="OK";
        public String Nama="Winda";
        public String Petugas="Winda";
        public String IP="10.0.2.2";
        public String Operasi="CAll";
        public String StartSub="1";
        public String StarService="1";
        public String DataBarcode="125/222/315/10";
        public String Password="admin";
        public String NamaLayanan[]={"Pengambilan 1,Pengambilan 2"};
        public String SubLayanan[]={"Layanan 1", "Layanan 2", "Layanan 3"};
        public String Hold[]={"A1", "A2", "A3"};
        public String Skip[]={"B1", "B2", "B3"};
        public boolean Admin=true;
        public String Start="00:00:01" ;
        public String Awal="23:59:00" ;
    }

    // Output data
    public static class DataOutput
    {
        public Integer ID=1;
        public Integer Nomor=1;
        public Integer Layanan=1;
        public Integer Loket=1;
        public Integer SID=1;
        public Integer LayananLoket=1;
        public Integer SisaNomor=0;
        public Integer LayananTujuan=0;
        public Integer TotalTransaksi=1;
        public String BatasBawah="00:00:01";
        public String BatasAtas="23:59:00";
        public String Command="Call";
        public String CounterName="Counter 1";
        public Integer Counter=1;
        public String User="Admin";
        public String Confrim="OK";
        public String Nama="Winda";
        public String Petugas="Winda";
        public String IP="10.0.2.2";
        public String Operasi="CAll";
        public String StartSub="1";
        public String StarService="1";
        public String DataBarcode="125/222/315/10";
        public String Password="admin";
        public String NamaLayanan[]={"Pengambilan 1,Pengambilan 2"};
        public String SubLayanan[]={"Layanan 1", "Layanan 2", "Layanan 3"};
        public String Hold[]={"A1", "A2", "A3"};
        public String Skip[]={"B1", "B2", "B3"};
        public boolean Admin=true;
        public String Start="00:00:01" ;
        public String Awal="23:59:00" ;
    }
// Reques Server
    public static class MyRequestMsg
    {
        public double Number1;
        public double Number2;
    }
// Respon Server
    public static class MyResponseMsg
    {
        public double Result;
    }


        // Communication // Clientpublic String
    public String  Port_id ="8091";
    public String IPPort_id;//="111.111.10.1"; //"10.0.2.2";
    private IDuplexChannelWrapper myDuplexChannelWrapper;
    private IDuplexOutputChannel myOutputChannel;
    private IDuplexTypedMessageSender<DataOutput, DataInput> SendData;
    private IDuplexTypedMessageSender<DataOutput, DataInput> SendDataDisplay;
    public TypedResponseReceivedEventArgs<DataOutput> aRecive;
    // Comunicatian Server
    public String ServerPort_id ="4502";
    public String IPServerPort_id;//="111.111.10.1"; //"10.0.2.2";
    private static IDuplexTypedMessageReceiver<MyResponseMsg, MyRequestMsg> myReceiver;
   // private static IDuplexTypedMessageReceiver<DataOutput, DataInput> SendDataDisplay;

    //Queing Sistem
    public boolean isConnect;
    public Integer Layanan = 1;
    public Boolean TombolAktif;
    public String btAtas, btBawah;
    public String btsBawah, btsAtas;
    public String NamaLayanan[];
    public String SubLayanan[];
    public String SubLay;
    public Integer LayananTransfer = 6;
    public String CounterName = "Teller 1";
    public Boolean isAdvance  = false;
    public Integer Counter  = 1;
    public Boolean IsConnect  = false;
    public Boolean isLayananOk  = false;
    public Integer counterService ;
    public Integer ctLayanan ;
    public Boolean sudahReset ;
    public Boolean NewTotal ;
    public Boolean AllowToEdit ;
    public Integer TotalQueue;
    public Integer TotalHoldNumber;
    public String numHold[]={"A1", "A2", "A3"};
    public String numSub[]={"Layanan 1", "Layanan 2", "Layanan 3"};
    public String HoldNumber="A 0000" ;;
    public Integer dispLayanan;
    public Integer CurrentDisplay;
    public String etUser = "Oounter 1";
    public Integer trnID= 0;
    public Integer layID= 0;
    public String listLayanan ="1";


    //Tombol
    public Boolean sudahFinish;
    public Boolean sudahTransfer;
    public Boolean sudahPending;
    public Boolean sudahAdvance;
    public Boolean sudahPass;
    public Boolean CallClick;
    public Boolean RecallClick;
    public Boolean CallPendingClick;
    public Boolean TransferClick;
    public Boolean PendingClicked;

    // UI controls
    private ImageButton myConnectbtn;
    private ImageButton myLoginbtn;
    private ImageButton myLogoutbtn;
    private ImageButton myClosebtn;
    private ImageButton mySettingbtn;
    private ImageButton myCallbtn;
    private ImageButton myCallPendingbtn;
    private ImageButton myRecallbtn;
    private ImageButton myTransferbtn;
    private ImageButton mySatrtbtn;
    private ImageButton myFinishbtn;
    private ImageButton myPendingbtn;
    private ImageView myUserimage;
    private TextView myNomorAntritxt;
    private TextView myLoginUstxt ;
    private TextView myStatustxt ;
    private TextView myStatusConecttxt;
    private TextView myPendingtxt;
    private TextView myTotQueuetxt;
//UI Server
private TextView myDisplayStatustxt ;

    // UI tread
    public Handler myRefresh = new Handler();
    public Handler myRefreshLogin = new Handler();
    public Handler myRefreshQueueNumber = new Handler();
    ObjectAnimator textColorAnim;
    private Animation mnAnim;
    CountDownTimer countDownTimer;          // built in android class CountDownTimer
    boolean blink;

    @Override
    public void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main);
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN, WindowManager.LayoutParams.FLAG_FULLSCREEN);
        try {
            FileInputStream fis = openFileInput("ClientSetting.ini");
            InputStreamReader isr = new InputStreamReader(fis);
            char[] inputBuffer = new char[100];
            String dataToRead = "";
            int charRead;
            while ((charRead = isr.read(inputBuffer)) > 0) {
                String readString = String.copyValueOf(inputBuffer, 0,
                        charRead);
                dataToRead += readString;
                inputBuffer = new char[100];
            }
            String Ceck = dataToRead;
            if (!Ceck.equals(""))
            {
                String[] tmp = Ceck.split("\r\n");
                IPPort_id=(tmp[0]);
                CounterName =(tmp[1]);
                Counter = Integer.parseInt(tmp[2]);
                Layanan = Integer.parseInt(tmp[3]);
               // Toast.makeText(getBaseContext(),IPPort_id +"  " + CounterName +"  " + Counter +"  " + Layanan , Toast.LENGTH_SHORT).show();
            }

        } catch (IOException e) {
            // TODO Auto-generated catch block
        }
        openConnection();
        //openConnectionDisplay();
        // Get UI widgets.
        myStatusConecttxt = (TextView) findViewById(R.id.txtSatatusConnect );
        myStatustxt = (TextView) findViewById(R.id.txtStatus);
        //myDisplayStatustxt = (TextView) findViewById(R.id.txtStatusDisplay);
        myUserimage = (ImageView)findViewById(R.id.imvUser);
        myTotQueuetxt = (TextView) findViewById(R.id.txtTotQueue );
        myPendingtxt = (TextView) findViewById(R.id.txtTotHolding);
        myLoginUstxt = (TextView ) findViewById(R.id.txtUserLogin );
        myNomorAntritxt = (TextView ) findViewById(R.id.txtNomor);
        myConnectbtn = (ImageButton) findViewById(R.id.imgConnect);
        myConnectbtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                onConection(v);
            }
        });
        myLoginbtn = (ImageButton) findViewById(R.id.imgLogin );
        myLoginbtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (! IsConnect )
                {
                    displayLogin();

                }

            }
        });
        myLogoutbtn = (ImageButton) findViewById(R.id.imgLogout );
        myLogoutbtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if ( IsConnect )
                {
                    sendRequest(SendData, "Logout", CounterName, Layanan, Counter, etUser, "");
                    loginUser("User Is Logout");
                    userStatus("Not Acces") ;
                    QueueNumber("0000") ;
                    CurentNumber("0", "0000");
                    userChange("false");
                    IsConnect = false;
                }

            }
        });
        mySettingbtn  = (ImageButton) findViewById(R.id.imgSetting );
        mySettingbtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if ( !IsConnect || IsConnect )
                {
                    sendRequest(SendData, "Logout",CounterName ,Layanan ,Counter, etUser, "");
                    loginUser("User Is Logout");
                    userStatus("Not Acces") ;
                    QueueNumber("0000") ;
                    CurentNumber("0", "0000");
                    userChange("false");
                    IsConnect = false;
                    sendRequest(SendData, "RequesLayanan", CounterName, Layanan, Counter, etUser, "");
                   // Intent act2 = new Intent(main_class.this, config_class.class);
                    // startActivity(act2);
                    displaySetting();
                }

            }
        });
        myClosebtn  = (ImageButton) findViewById(R.id.imgClose );
        myClosebtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                sendRequest(SendData, "Logout",CounterName ,Layanan ,Counter, etUser, "");
                onDestroy();
                finish();
            }
        });
        myPendingbtn = (ImageButton) findViewById(R.id.imgPending );
        myPendingbtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (IsConnect)// && ((! sudahTransfer)) && ((! sudahPending)) && ((! sudahPass)) && ((! sudahAdvance)))
                {
                    sendRequest(SendData,"Hold",CounterName ,Layanan ,Counter, "", "");
                    userStatus("Pending Number") ;
                }
            }
        });
        myCallPendingbtn = (ImageButton) findViewById(R.id.imgCallPending );
        myCallPendingbtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (IsConnect)// && ((! sudahTransfer)) && ((! sudahPending)) && ((! sudahPass)) && ((! sudahAdvance)))
                {
                  //  sendRequest(SendData,"Hold",CounterName ,Layanan ,Counter, "", "");
                    displayPending() ;
                }
            }
        });
        myCallbtn = (ImageButton) findViewById(R.id.imgCall);
        myCallbtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v)
            {
                if (IsConnect)
                {
                    try
                    {
                        CallClick = true;
                        sendRequest(SendData, "Call", CounterName, Layanan, Counter, "", "");
                        TombolAktif = true;
                        sudahTransfer = false;
                        sudahPending = false;
                        sudahPass = false;
                        sudahAdvance = false;
                        userStatus("Call Number") ;
                        operation_btn();
                    }
                    catch (RuntimeException ex)
                    {
                        TombolAktif = false;
                        sudahTransfer = false;
                        sudahPending = false;
                        sudahPass = false;
                        sudahAdvance = false;
                    }
                    // Toast.makeText(getBaseContext(),IPPort_id +"  " + CounterName +"  " + Counter +"  " + Layanan , Toast.LENGTH_SHORT).show();

                }

            }
        });
        myRecallbtn = (ImageButton) findViewById(R.id.imgRecall);
        myRecallbtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v)
            {
                if (IsConnect) //&&  (!TombolAktif) && (! sudahAdvance) && (! sudahPass))
                {
                    try
                    {
                        sendRequest(SendData,"Recall",CounterName ,Layanan ,Counter, "", "");
                        RecallClick = true;
                        TombolAktif = true;
                        userStatus("Recall Number") ;
                        operation_btn();

                    }
                    catch (RuntimeException ex)
                    {
                        TombolAktif = false;
                    }

                }

            }
        });
        myTransferbtn  = (ImageButton) findViewById(R.id.imgTransfer );
        myTransferbtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v)
            {
                if (IsConnect )//&& ((! TombolAktif)) && ((! sudahTransfer)) && ((! sudahPass)) && ((! sudahAdvance)))
                {
                    // sendRequest(SendData, "ReqNumber", CounterName, Layanan, Counter, etUser, "");
                    //sleep(5000);
                    displayTransfer();
                }

            }
        });
        mySatrtbtn   = (ImageButton) findViewById(R.id.imgStart );
        mySatrtbtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v)
            {
                if (IsConnect )//&& ((! TombolAktif)) && ((! sudahTransfer)) && ((! sudahPass)) && ((! sudahAdvance)))
                {
                    // sendRequest(SendData, "ReqNumber", CounterName, Layanan, Counter, etUser, "");
                    //sleep(5000);
                    displaySubLayanan();
                }

            }
        });
        myFinishbtn   = (ImageButton) findViewById(R.id.imgFinish);
        myFinishbtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v)
            {
                if (IsConnect )//&& ((! TombolAktif)) && ((! sudahTransfer)) && ((! sudahPass)) && ((! sudahAdvance)))
                {
                    sendRequest(SendData, "Finish", CounterName, Layanan, Counter, "", "");
                    enabel_btn() ;
                    userStatus("Finish Report") ;
                }

            }
        });
    }

    @Override
    public void onDestroy()
    {
        // Stop listening to response messages.
        myDuplexChannelWrapper.detachDuplexOutputChannel();

        super.onDestroy();
    }
    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        MenuInflater inflater = getMenuInflater();
        inflater.inflate(R.menu.setting_menu, menu);
        return true;
    }

    @Override

    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        switch (item.getItemId()) {
            case R.id.setting_btn:
               // Intent act2 = new Intent(main_class.this, config_class.class);
               // startActivity(act2);
                sendRequest(SendData, "Logout", CounterName ,Layanan ,Counter, etUser, "");
                loginUser("User Is Logout");
                QueueNumber("0000") ;
                CurentNumber("0","0000");
                displaySetting();
                return true;
            case R.id.close_btn:
              /*  Intent act3 = new Intent(main_class.this ,se.class);
                startActivity(act3);
                isFinishing();*/
                sendRequest(SendData, "Logout", CounterName ,Layanan ,Counter, etUser, "");
                finish();
                return true;
            default:
                return super.onOptionsItemSelected(item);
        }
    }

    private void openConnectionDisplay()
    {
        IMessagingSystemFactory anInternalMessaging = new ThreadMessagingSystemFactory();
        IChannelWrapperFactory aChannelWrapperFactory = new ChannelWrapperFactory();
        myDuplexChannelWrapper = aChannelWrapperFactory.createDuplexChannelWrapper();
        IDuplexTypedMessagesFactory aCommandsFactory = new DuplexTypedMessagesFactory();

        // Sender to sum two numbers.
        SendDataDisplay = aCommandsFactory.createDuplexTypedMessageSender(DataOutput.class, DataInput.class);
        SendDataDisplay.responseReceived().subscribe(myOnResultResponse);

        //Sender Display

        try
        {
            // Connect senders with the channel wrapper.

            myDuplexChannelWrapper.attachDuplexInputChannel(anInternalMessaging.createDuplexInputChannel("SendDataDisplay"));
          //  SendData.attachDuplexOutputChannel(anInternalMessaging.createDuplexOutputChannel("SendDataDisplay"));

            IMessagingSystemFactory aMessaging = new TcpMessagingSystemFactory();
            // myDuplexChannelWrapper.attachDuplexOutputChannel(aMessaging.createDuplexOutputChannel("tcp://10.0.2.2:8091/"));
          //  myDuplexChannelWrapper.connectionClosed().subscribe(myOnConnectionClosed);
           // myDuplexChannelWrapper.connectionOpened().subscribe(myOnConnectionOpened);

            myOutputChannel =aMessaging.createDuplexOutputChannel("tcp://10.0.2.2:8091/");
            myOutputChannel.connectionClosed().subscribe(myDisplayConnectionClosed);
            myOutputChannel.connectionOpened().subscribe(myDisplayConnectionOpened);
            try
            {
                myDuplexChannelWrapper.attachDuplexOutputChannel(myOutputChannel);

            }
            catch (Exception err)
            {
                EneterTrace.error("Connecting to the service failed.", err);
            }
        }
        catch (Exception err)
        {
            EneterTrace.error("Connecting to the service failed.", err);
        }
    }
    private void openConnection()
    {
        IMessagingSystemFactory anInternalMessaging = new ThreadMessagingSystemFactory();
        IChannelWrapperFactory aChannelWrapperFactory = new ChannelWrapperFactory();
        myDuplexChannelWrapper = aChannelWrapperFactory.createDuplexChannelWrapper();
        IDuplexTypedMessagesFactory aCommandsFactory = new DuplexTypedMessagesFactory();

        // Sender to sum two numbers.
        SendData = aCommandsFactory.createDuplexTypedMessageSender(DataOutput.class, DataInput.class);
        SendData.responseReceived().subscribe(myOnResultResponse);

        //Sender Display

        try
        {
            // Connect senders with the channel wrapper.

            myDuplexChannelWrapper.attachDuplexInputChannel(anInternalMessaging.createDuplexInputChannel("SendData"));
            SendData.attachDuplexOutputChannel(anInternalMessaging.createDuplexOutputChannel("SendData"));

            IMessagingSystemFactory aMessaging = new TcpMessagingSystemFactory();
            // myDuplexChannelWrapper.attachDuplexOutputChannel(aMessaging.createDuplexOutputChannel("tcp://10.0.2.2:8091/"));
            //  myDuplexChannelWrapper.connectionClosed().subscribe(myOnConnectionClosed);
            // myDuplexChannelWrapper.connectionOpened().subscribe(myOnConnectionOpened);

            myOutputChannel =aMessaging.createDuplexOutputChannel("tcp://" + IPPort_id + ":" + Port_id + "/");
            myOutputChannel.connectionClosed().subscribe(myOnConnectionClosed);
            myOutputChannel.connectionOpened().subscribe(myOnConnectionOpened);
            try
            {
                myDuplexChannelWrapper.attachDuplexOutputChannel(myOutputChannel);

            }
            catch (Exception err)
            {
                EneterTrace.error("Connecting to the service failed.", err);
            }
        }
        catch (Exception err)
        {
            EneterTrace.error("Connecting to the service failed.", err);
        }
    }

    private void openServer()
    {
        try
        {
            // Start the TCP Policy server.
            // Note: Silverlight requests the policy xml to check if the connection
            //       can be established.
            TcpPolicyServer aPolicyServer = new TcpPolicyServer();
            aPolicyServer.startPolicyServer();

            // Create receiver that receives MyRequestMsg and
            // responses MyResponseMsg
            IDuplexTypedMessagesFactory aReceiverFactory = new DuplexTypedMessagesFactory();
            myReceiver = aReceiverFactory.createDuplexTypedMessageReceiver(MyResponseMsg.class, MyRequestMsg.class);

            // Subscribe to handle incoming messages.
            // myReceiver.messageReceived().subscribe(myOnMessageReceived);

            // Create input channel listening to TCP.
            // Note: Silverlight can communicate only on ports: 4502 - 4532
            IMessagingSystemFactory aMessaging = new TcpMessagingSystemFactory();
            IDuplexInputChannel anInputChannel = aMessaging.createDuplexInputChannel("tcp://" + IPServerPort_id + ":" + ServerPort_id + "/");
            try
            {
                // Attach the input channel to the receiver and start the listening.
                myReceiver.attachDuplexInputChannel(anInputChannel);

                // Detach the duplex input channel and stop the listening.
                // Note: it releases the thread listening to messages.
                myReceiver.detachDuplexInputChannel();
            }
            catch (Exception err)
            {
                EneterTrace.error("Connecting to the service failed.", err);
            }
            aPolicyServer.stopPolicyServer();

        }
        catch (Exception err)
        {
            EneterTrace.error("Connecting to the service failed.", err);
        }



        // Stop the TCP policy server.

    }
    private void onConnectionDisplay(boolean isConnected)
    {
        // Get the connection status.
        final String aStatus = isConnected ? "Connected" : "Disconnected";

        // This event can come from various threads, so
        // enforce using the UI thread for displaying.
        myRefresh.post(new Runnable() {
            @Override
            public void run() {
                myDisplayStatustxt.setText(aStatus);
                if (aStatus == "Display Disconnected") {
                    Toast.makeText(getBaseContext(), "Server Is Not Ready OR Server Close", Toast.LENGTH_SHORT).show();
                } else if (aStatus == "Display Connected") {
                    Toast.makeText(getBaseContext(), "Server Is Ready ", Toast.LENGTH_SHORT).show();
                }
            }
        });
    }
    private EventHandler<DuplexChannelEventArgs> myDisplayConnectionOpened =
            new EventHandler<eneter.messaging.messagingsystems.messagingsystembase.DuplexChannelEventArgs>()
            {
                @Override
                public void onEvent(Object sender,DuplexChannelEventArgs e)
                {
                    onConnectionDisplay(true);
                }
            };

    // Processes when close connection is indicated.
    private EventHandler<DuplexChannelEventArgs> myDisplayConnectionClosed =
            new EventHandler<DuplexChannelEventArgs>()
            {
                @Override
                public void onEvent(Object sender, DuplexChannelEventArgs e) {
                    onConnectionDisplay(false);
                }

            };

    private EventHandler<DuplexChannelEventArgs> myOnConnectionOpened =
            new EventHandler<eneter.messaging.messagingsystems.messagingsystembase.DuplexChannelEventArgs>()
            {
                @Override
                public void onEvent(Object sender,DuplexChannelEventArgs e)
                {
                    onConnectionChanged(true);
                }
            };

    // Processes when close connection is indicated.
    private EventHandler<DuplexChannelEventArgs> myOnConnectionClosed =
            new EventHandler<DuplexChannelEventArgs>()
            {
                @Override
                public void onEvent(Object sender, DuplexChannelEventArgs e) {
                    onConnectionChanged(false);
                }

            };
    private void onConnectionChanged(boolean isConnected)
    {
    // Get the connection status.
    final String aStatus = isConnected ? "Connected" : "Disconnected";

    // This event can come from various threads, so
    // enforce using the UI thread for displaying.
    myRefresh.post(new Runnable() {
        @Override
        public void run() {
            myStatusConecttxt.setText(aStatus);
            if (aStatus == "Disconnected") {
                Toast.makeText(getBaseContext(), "Server Is Not Ready OR Server Close", Toast.LENGTH_SHORT).show();
            } else if (aStatus == "Connected") {
                Toast.makeText(getBaseContext(), "Server Is Ready ", Toast.LENGTH_SHORT).show();
            }
        }
    });
    }

    private void onConection(View v)
    {
        myDuplexChannelWrapper.detachDuplexOutputChannel();
        try
        {
            myDuplexChannelWrapper.attachDuplexOutputChannel(myOutputChannel);
        }
        catch (Exception err)
        {
            EneterTrace.error("Connecting to the service failed.", err);
        }
    }

    private void sendRequest(IDuplexTypedMessageSender<DataOutput, DataInput> sender,String Command,String CounterName,Integer Layanan,Integer Counter,String User,String Password)
    {
        DataInput anInputData = new DataInput();
        anInputData .Command  = Command;
        anInputData .CounterName  = CounterName;
        anInputData .Layanan  = Layanan ;
        anInputData .Counter = Counter;
        anInputData .User = User;
        anInputData .Password = Password;
        try
        {
            sender.sendRequestMessage(anInputData);
        }
        catch (Exception err)
        {
            EneterTrace.error("Sending of calculation request failed.", err);
        }
    }
    private void sendRequest(IDuplexTypedMessageSender<DataOutput, DataInput> sender,String Command,String CounterName,Integer Layanan,Integer Counter,String User,String Password,Integer Nomor,Integer LayananTujuan)
    {
        DataInput anInputData = new DataInput();
        anInputData .Command  = Command;
        anInputData .CounterName  = CounterName;
        anInputData .Layanan  = Layanan ;
        anInputData .Counter = Counter;
        anInputData .User = User;
        anInputData .Password = Password;
        anInputData .Nomor = Nomor;
        anInputData .LayananTujuan = LayananTujuan ;
        try
        {
            sender.sendRequestMessage(anInputData);
        }
        catch (Exception err)
        {
            EneterTrace.error("Sending of calculation request failed.", err);
        }
    }
    private void sendRequest(IDuplexTypedMessageSender<DataOutput, DataInput> sender,String Command,String CounterName,Integer Layanan,Integer Counter,String User,String Password,Integer Nomor,Integer LayananTujuan,String StarService)
    {
        DataInput anInputData = new DataInput();
        anInputData .Command  = Command;
        anInputData .CounterName  = CounterName;
        anInputData .Layanan  = Layanan ;
        anInputData .Counter = Counter;
        anInputData .User = User;
        anInputData .Password = Password;
        anInputData .Nomor = Nomor;
        anInputData .LayananTujuan = LayananTujuan ;
        anInputData .StarService = StarService ;
        try
        {
            sender.sendRequestMessage(anInputData);
        }
        catch (Exception err)
        {
            EneterTrace.error("Sending of calculation request failed.", err);
        }
    }
    private String getCharForNumber(Integer  i)
    {
        char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".toCharArray();
        if (i > 25) {
            return null;
        }
        return Character.toString(alphabet[i]);
    }
    private void userChange(String isConnected)
    {
        // Get the connection status.
        final String  aStatus = isConnected;
        // This event can come from various threads, so
        // enforce using the UI thread for displaying.
        myRefresh.post(new Runnable() {
            @Override
            public void run() {
                if (aStatus.equals("true")) {
                    myUserimage.setBackgroundResource(R.drawable.user_in);
                } else if (aStatus.equals("false")) {
                    myUserimage.setBackgroundResource(R.drawable.user_out);
                }
            }
        });
    }
    private void userStatus(String isConnected)
    {
        // Get the connection status.
        final String  aStatus = isConnected;
        // This event can come from various threads, so
        // enforce using the UI thread for displaying.
        myRefresh.post(new Runnable() {
            @Override
            public void run() {

                myStatustxt.setText(aStatus);
            }
        });
    }
    private void loginUser(String statuslbl)
    {
        // Get the connection status.
        final String aStatus =statuslbl;

        // This event can come from various threads, so
        // enforce using the UI thread for displaying.
        myRefresh.post(new Runnable()
        {
            @Override
            public void run()
            {
                myLoginUstxt .setText(aStatus);
            }
        });
    }
    private void CurentNumber(String Lay ,String Nomor )
    {
        // Get the connection status.
        final String aLayanan =Lay;
        final String aNomor =Nomor;

        // This event can come from various threads, so
        // enforce using the UI thread for displaying.
        myRefresh.post(new Runnable()
        {
            @Override
            public void run()
            {
                //myTotQueuetxt .setText(aStatus);
               // myTotQueuetxt.setTextAppearance(getApplicationContext(), R.style.normalText);
                countDownTimer = new CountDownTimer(10000, 500) {
                    // 500 means, onTick function will be called at every 500 milliseconds

                    @Override
                    public void onTick(long leftTimeInMilliseconds) {
                        myNomorAntritxt .setTextAppearance(getApplicationContext(), R.style.normalTextNumber);
                        if ( blink )
                        {
                             //   myTotQueuetxt.setVisibility(View.VISIBLE);
                            myNomorAntritxt.setTextAppearance(getApplicationContext(), R.style.blinkTextNumber );
                                // if blink is true, textview will be visible
                        }
                        else
                        {
                             //   myTotQueuetxt.setVisibility(View.INVISIBLE);
                            myNomorAntritxt.setTextAppearance(getApplicationContext(), R.style.normalTextNumber );
                        }

                        blink = !blink;         // toggle the value of blink
                        myNomorAntritxt .setText(aLayanan + " " + aNomor);
                    }

                    @Override
                    public void onFinish() {
                        // this function will be called when the timecount is finished
                       // myTotQueuetxt.setVisibility(View.VISIBLE);
                        myNomorAntritxt.setTextAppearance(getApplicationContext(), R.style.blinkTextNumber );
                       //'' enabel_btn();
                    }

                }.start();
            }
        });
    }
    private void QueueNumber(String statuslbl)
    {
        // Get the connection status.
        final String aStatus =statuslbl;

        // This event can come from various threads, so
        // enforce using the UI thread for displaying.
        myRefresh.post(new Runnable()
        {
            @Override
            public void run()
            {
                //myTotQueuetxt .setText(aStatus);
                // myTotQueuetxt.setTextAppearance(getApplicationContext(), R.style.normalText);
                countDownTimer = new CountDownTimer(1500, 500) {
                    // 500 means, onTick function will be called at every 500 milliseconds

                    @Override
                    public void onTick(long leftTimeInMilliseconds) {
                        myTotQueuetxt.setTextAppearance(getApplicationContext(), R.style.normalText);
                        if ( blink )
                        {
                            //   myTotQueuetxt.setVisibility(View.VISIBLE);
                            myTotQueuetxt.setTextAppearance(getApplicationContext(), R.style.blinkText);
                            // if blink is true, textview will be visible
                        }
                        else
                        {
                            //   myTotQueuetxt.setVisibility(View.INVISIBLE);
                            myTotQueuetxt.setTextAppearance(getApplicationContext(), R.style.normalText);
                        }

                        blink = !blink;         // toggle the value of blink
                        myTotQueuetxt .setText(aStatus);
                    }

                    @Override
                    public void onFinish() {
                        // this function will be called when the timecount is finished
                        // myTotQueuetxt.setVisibility(View.VISIBLE);
                        myTotQueuetxt.setTextAppearance(getApplicationContext(), R.style.blinkText);
                    }

                }.start();
            }
        });
    }
    private void HoldingNumber(String statuslbl)
    {
        // Get the connection status.
        final String aStatus =statuslbl;

        // This event can come from various threads, so
        // enforce using the UI thread for displaying.
        myRefresh.post(new Runnable() {
            @Override
            public void run() {
                //myTotQueuetxt .setText(aStatus);
                // myTotQueuetxt.setTextAppearance(getApplicationContext(), R.style.normalText);
                countDownTimer = new CountDownTimer(2000, 500) {
                    // 500 means, onTick function will be called at every 500 milliseconds

                    @Override
                    public void onTick(long leftTimeInMilliseconds) {
                        myPendingtxt.setTextAppearance(getApplicationContext(), R.style.normalText);
                        if (blink) {
                            //   myTotQueuetxt.setVisibility(View.VISIBLE);
                            myPendingtxt.setTextAppearance(getApplicationContext(), R.style.blinkText);
                            // if blink is true, textview will be visible
                        } else {
                            //   myTotQueuetxt.setVisibility(View.INVISIBLE);
                            myPendingtxt.setTextAppearance(getApplicationContext(), R.style.normalText);
                        }

                        blink = !blink;         // toggle the value of blink
                        myPendingtxt.setText(aStatus);
                    }

                    @Override
                    public void onFinish() {
                        // this function will be called when the timecount is finished
                        // myTotQueuetxt.setVisibility(View.VISIBLE);
                        myTotQueuetxt.setTextAppearance(getApplicationContext(), R.style.blinkText);
                    }

                }.start();
            }
        });
    }
    private void onResponseReceived(Object sender, final TypedResponseReceivedEventArgs<DataOutput> e)
    {
        // Display the result.
        // Note: Marshal displaying to the correct UI thread.
        aRecive= e;
        myRefresh.post(new Runnable() {
            @Override
            public void run() {
                //Toast.makeText(getBaseContext(), e.getResponseMessage().Confrim + "    " + e.getResponseMessage() .Counter ,
                //  Toast.LENGTH_SHORT).show();
                try {
                    if (e.getResponseMessage().Admin) {
                        if (e.getResponseMessage().Command.equals("Login")) {
                            if (e.getResponseMessage().Confrim.equals("OK")) {
                                component_class cc = new component_class();
                                loginUser(CounterName + " " + "login Us As");
                                IsConnect = true;
                                Toast.makeText(getBaseContext(), "Counter Connect To Server", Toast.LENGTH_SHORT).show();
                                TotalQueue = e.getResponseMessage().SisaNomor;
                                userChange("true");
                                try {
                                    NamaLayanan = e.getResponseMessage().NamaLayanan;
                                    SubLayanan = e.getResponseMessage().SubLayanan;
                                    numSub = SubLayanan;

                                } catch (RuntimeException ex) {
                                    Toast.makeText(getBaseContext(), ex.toString(), Toast.LENGTH_SHORT).show();
                                }
                                if (e.getResponseMessage().Hold != null) {
                                    try {
                                        TotalHoldNumber = e.getResponseMessage().Hold.length;
                                        // myPendingtxt .setText(TotalHoldNumber) ;
                                        HoldingNumber(String.format("%04d", TotalHoldNumber));
                                        numHold = e.getResponseMessage().Hold;
                                        //  Toast.makeText(getBaseContext(), TotalHoldNumber, Toast.LENGTH_SHORT).show();
                                    } catch (RuntimeException ex) {
                                        Toast.makeText(getBaseContext(), ex.toString(), Toast.LENGTH_SHORT).show();
                                    }

                                } else {
                                    TotalHoldNumber = 0;
                                    HoldingNumber(String.format("%04d", TotalHoldNumber));
                                    numHold = e.getResponseMessage().Hold;
                                    //myPendingtxt .setText(TotalHoldNumber) ;
                                }
                                if (Layanan == LayananTransfer) {

                                }
                                try {
                                    btBawah = e.getResponseMessage().BatasBawah;
                                    btAtas = e.getResponseMessage().BatasAtas;
                                } catch (RuntimeException ex) {
                                    Toast.makeText(getBaseContext(), ex.toString(), Toast.LENGTH_SHORT).show();
                                }
                            } else {
                                Toast.makeText(getBaseContext(), e.getResponseMessage().Confrim, Toast.LENGTH_SHORT).show();
                            }
                        } else if (e.getResponseMessage().Command.equals("Logout")) {
                            try {
                                IsConnect = false;
                                userChange("false");
                                // myLoginUstxt .setText("Logout");
                                Toast.makeText(getBaseContext(), "Server Close", Toast.LENGTH_SHORT).show();
                            } catch (RuntimeException ex) {

                            }
                        } else if (e.getResponseMessage().Command.equals("RequesLayanan")) {
                            try {
                                NamaLayanan = e.getResponseMessage().NamaLayanan;
                                isLayananOk = true;
                            } catch (RuntimeException ex) {
                                Toast.makeText(getBaseContext(), ex.toString(), Toast.LENGTH_SHORT).show();
                            }
                        } else {
                            if (e.getResponseMessage().Command.equals("Call")) {

                                try {
                                    dispLayanan = e.getResponseMessage().Layanan - 1;
                                    CurrentDisplay = e.getResponseMessage().Nomor;
                                    CurentNumber(getCharForNumber(dispLayanan), String.format("%04d", CurrentDisplay));

                                } catch (RuntimeException ex) {
                                    // Toast.makeText(getBaseContext(), ex.toString(), Toast.LENGTH_SHORT).show();
                                }
                                try {
                                    btBawah = e.getResponseMessage().BatasBawah;
                                    btAtas = e.getResponseMessage().BatasAtas;
                                } catch (RuntimeException ex) {
                                    Toast.makeText(getBaseContext(), ex.toString(), Toast.LENGTH_SHORT).show();
                                }
                            } else if (e.getResponseMessage().Command.equals("Total")) {
                                try {
                                    aRecive = e;
                                    Integer tmpLayanan = e.getResponseMessage().Layanan;
                                    if (tmpLayanan == Layanan) {
                                        TotalQueue = e.getResponseMessage().SisaNomor;
                                    }
                                    NewTotal = true;
                                    QueueNumber(String.format("%04d", TotalQueue));
                                } catch (RuntimeException ex) {

                                }

                            } else if ((e.getResponseMessage().Command.equals("Hold")))// || (e.getResponseMessage().Command.equals("Hold")) || (e.getResponseMessage().Command.equals("CallStore")) || (e.getResponseMessage().Command.equals("CallHold")))
                            {

                                try {
                                    if (e.getResponseMessage().Hold != null) {
                                        TotalHoldNumber = e.getResponseMessage().Hold.length;
                                        HoldingNumber(String.format("%04d", TotalHoldNumber));
                                        numHold = e.getResponseMessage().Hold;
                                        //Toast.makeText(getBaseContext(),TotalHoldNumber, Toast.LENGTH_SHORT).show();
                                        // myPendingtxt .setText(TotalHoldNumber) ;
                                    } else {
                                        // TotalHoldNumber = 0;
                                        // HoldingNumber(String.format("%04d", TotalHoldNumber));
                                        // myPendingtxt .setText(TotalHoldNumber ) ;
                                    }
                                } catch (RuntimeException ex) {

                                }

                            } else if ((e.getResponseMessage().Confrim.equals("Transfer")) || (e.getResponseMessage().Confrim.equals("Store")) || (e.getResponseMessage().Confrim.equals("Empty"))) {
                                if (e.getResponseMessage().Confrim.equals("Empty")) {
                                    try {
                                        Integer tmpLayanan = e.getResponseMessage().Layanan;
                                        if (tmpLayanan == Layanan) {
                                            TotalQueue = e.getResponseMessage().SisaNomor;
                                        }
                                    } catch (RuntimeException exe) {

                                    }

                                    // myTotQueuetxt.setText(TotalQueue);
                                }
                                TombolAktif = false;
                            }
                        }


                    }


                } catch (RuntimeException ex) {

                }
            }
        });
    }

    private EventHandler<TypedResponseReceivedEventArgs<DataOutput>> myOnResultResponse = new EventHandler<TypedResponseReceivedEventArgs<DataOutput>>()
    {
        @Override
        public void onEvent(Object sender, TypedResponseReceivedEventArgs<DataOutput> e)
        {
            onResponseReceived(sender, e);
        }
    };
    public void displayLogin() {
        LayoutInflater inflater = getLayoutInflater();
        View alertLayout = inflater.inflate(R.layout.login_dialog, null);
        final EditText etUsername = (EditText) alertLayout.findViewById(R.id.et_Username);
        final EditText etPassword = (EditText) alertLayout.findViewById(R.id.et_Password);
        final CheckBox cbShowPassword = (CheckBox) alertLayout.findViewById(R.id.cb_ShowPassword);

        cbShowPassword.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {

            @Override
            public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {
                if (isChecked)
                    etPassword.setTransformationMethod(null);
                else
                    etPassword.setTransformationMethod(PasswordTransformationMethod.getInstance());
            }
        });

        AlertDialog.Builder alert = new AlertDialog.Builder(this);
        alert.setTitle("Login");
        alert.setView(alertLayout);
        alert.setCancelable(false);
        alert.setNegativeButton("Cancel", new DialogInterface.OnClickListener() {

            @Override
            public void onClick(DialogInterface dialog, int which) {
                Toast.makeText(getBaseContext(), "Cancel Login", Toast.LENGTH_SHORT).show();
            }
        });

        alert.setPositiveButton("Login", new DialogInterface.OnClickListener() {

            @Override
            public void onClick(DialogInterface dialog, int which) {
                // code for matching password
                String user = etUsername.getText().toString();
                String pass = etPassword.getText().toString();
                sendRequest(SendData, "Login",CounterName ,Layanan ,Counter,user, pass);
                etUser = user;
              //  Toast.makeText(getBaseContext(), "Username: " + user + " Password: " + pass, Toast.LENGTH_SHORT).show();
            }
        });
        AlertDialog dialog = alert.create();
        dialog.show();
    }
    public void displayPending() {
        LayoutInflater inflater = getLayoutInflater();
        View alertLayout = inflater.inflate(R.layout.hold_layout, null);
        final ListView   etListPending = (ListView) alertLayout.findViewById(R.id.listViewHold);
        etListPending.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                CheckedTextView check = (CheckedTextView) view;
                check.setChecked(check.isChecked());
                String item = (String) etListPending.getItemAtPosition(position);
                HoldNumber = item;

            }

        });
        AlertDialog.Builder alert = new AlertDialog.Builder(this);
        final List<String> layList = new ArrayList<String>();
        try
        {
          //  nameHold =aRecive.getResponseMessage().Hold.length ;

            //for(String k:aRecive.getResponseMessage().Hold)
            for(String k:numHold)
            {
                layList .add(k);
                ///   Toast.makeText(getBaseContext(),k, Toast.LENGTH_SHORT).show();
                ArrayAdapter<String> adapter = new ArrayAdapter<String>(getApplicationContext() ,android.R.layout.simple_list_item_single_choice,layList);
                adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
                etListPending.setChoiceMode(ListView.CHOICE_MODE_SINGLE);
                // Set the adapter to th spinner
                etListPending.setAdapter(adapter);

            }
        }
        catch (RuntimeException ex)
        {

        }

        alert.setTitle("Pending Nomor" + "     " + String.format("%03d", numHold.length) + "  Nomor");
        alert.setView(alertLayout);
        alert.setCancelable(false);


    alert.setNegativeButton("Cancel", new DialogInterface.OnClickListener() {

        @Override
        public void onClick(DialogInterface dialog, int which) {
            Toast.makeText(getBaseContext(), "Cancel", Toast.LENGTH_SHORT).show();
        }
    });

    alert.setPositiveButton("Call", new DialogInterface.OnClickListener() {

        @Override
        public void onClick(DialogInterface dialog, int which) {
            try
            {
                String pendingNumber =HoldNumber; // etListPending.getCheckedItemCount(1);
                String tmpNomor = pendingNumber;
                String alpabet = "A";
                String nmbLay = "";
                String newStr = tmpNomor.replace(" ", ",");
                String regex = ",";
                // split the string object
                String[] output = newStr.split(regex);
                alpabet = output[0];
                for (int i = 0; i < alpabet.length(); i++) {
                    nmbLay += ((int) alpabet.charAt(i) - 64);
                }
                String Nomor = output[1];
                String zerotmp="0";
                if (Integer.parseInt(Nomor) < 10) {
                    zerotmp = Nomor.replaceFirst("000", "");
                } else if (Integer.parseInt(Nomor) < 100 && Integer.parseInt(Nomor) > 9) {
                    zerotmp = Nomor.replaceFirst("00", "");
                } else if (Integer.parseInt(Nomor) > 99) {
                    zerotmp = Nomor.replaceFirst("0", "");
                }
                //  Toast.makeText(getBaseContext(),nmbLay +"  "+ zerotmp, Toast.LENGTH_SHORT).show();
                sendRequest(SendData, "CallHold", CounterName, Integer.parseInt(nmbLay),Counter , "", "",Integer.parseInt(zerotmp),0);
                userStatus("Call Pending") ;
                operation_btn();
            } catch (RuntimeException ex)
            {

            }

        }
    });
    AlertDialog dialog = alert.create();
    dialog.show();
}
    public void displaySubLayanan() {
        LayoutInflater inflater = getLayoutInflater();
        View alertLayout = inflater.inflate(R.layout.sublay_layout , null);
        final ListView   etListPending = (ListView) alertLayout.findViewById(R.id.listViewSub);
        etListPending.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                CheckedTextView check = (CheckedTextView) view;
                check.setChecked(check.isChecked());
                String item = (String) etListPending.getItemAtPosition(position);
                SubLay = item;
            }

        });
        AlertDialog.Builder alert = new AlertDialog.Builder(this);
        final List<String> layList = new ArrayList<String>();
        try
        {
            for(String k:numSub)
            {
                layList .add(k);
                ///   Toast.makeText(getBaseContext(),k, Toast.LENGTH_SHORT).show();
                ArrayAdapter<String> adapter = new ArrayAdapter<String>(getApplicationContext() ,android.R.layout.simple_list_item_single_choice,layList);
                adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
                etListPending.setChoiceMode(ListView.CHOICE_MODE_SINGLE);
                // Set the adapter to th spinner
                etListPending.setAdapter(adapter);

            }
        }
        catch (RuntimeException ex)
        {

        }

        alert.setTitle("Sub Pelayanan Report");
        alert.setView(alertLayout);
        alert.setCancelable(false);
        alert.setNegativeButton("Cancel", new DialogInterface.OnClickListener() {

            @Override
            public void onClick(DialogInterface dialog, int which) {
                Toast.makeText(getBaseContext(), "Cancel", Toast.LENGTH_SHORT).show();
            }
        });

        alert.setPositiveButton("Start", new DialogInterface.OnClickListener() {

            @Override
            public void onClick(DialogInterface dialog, int which) {
                try
                {
                    String LayananSub =SubLay; // etListPending.getCheckedItemCount(1);
                    sendRequest(SendData, "Start", CounterName, Layanan, Counter, "", "", 0, 0, LayananSub);
                    disebel_btn();
                    userStatus("Start Report");

                    Toast.makeText(getBaseContext(),"Start Report Prosess", Toast.LENGTH_SHORT).show();
                } catch (RuntimeException ex)
                {

                }

            }
        });
        AlertDialog dialog = alert.create();
        dialog.show();
    }
    public void displaySetting() {
        LayoutInflater inflater = getLayoutInflater();
        View alertLayout = inflater.inflate(R.layout.display_config, null);
       // final String  listLayanan;
        final Spinner esSpnerLayanan = (Spinner) alertLayout.findViewById(R.id.spnLayanan);

        final EditText estxtIP = (EditText)alertLayout .findViewById(R.id.txtIP);
        final EditText estxtUserCounter = (EditText)alertLayout .findViewById(R.id.txtUserCounter);
        final EditText estxtNomorCounter = (EditText)alertLayout .findViewById(R.id.txtNomorCounter);
        //final component_class  cccounter ;
        AlertDialog.Builder alert = new AlertDialog.Builder(this);
        alert.setTitle("Setting Client");
        alert.setView(alertLayout);
        List<String> list = new ArrayList<String>();
        list.add("Layanan 1");
        list.add("Layanan 2");
        list.add("Layanan 3");
        list.add("Layanan 4");
        list.add("Layanan 5");
        list.add("Layanan 6");
        ArrayAdapter<String> adapter = new ArrayAdapter<String>(getApplicationContext() ,android.R.layout.simple_spinner_item ,list);
        adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        // Set the adapter to th spinner
        esSpnerLayanan.setAdapter(adapter);
        /*  if(myStatusConecttxt.getText() == "Connected")
                {
                    final String nmLayanan[]=NamaLayanan;
                    for(String k:nmLayanan )
                    {
                        list .add(k);
                        Toast.makeText(getBaseContext(),k, Toast.LENGTH_SHORT).show();
                        ArrayAdapter<String> adapter = new ArrayAdapter<String>(getApplicationContext() ,android.R.layout.simple_spinner_item ,list);
                        adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
                        // Set the adapter to th spinner
                        esSpnerLayanan.setAdapter(adapter);
                    }

                }*/

        esSpnerLayanan.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {
                layID = position +1;
            }

            @Override
            public void onNothingSelected(AdapterView<?> parent) {
                //  m_tv.setText("");
            }
        });
        try {
            FileInputStream fis = openFileInput("ClientSetting.ini");
            InputStreamReader isr = new InputStreamReader(fis);
            char[] inputBuffer = new char[100];
            String dataToRead = "";
            int charRead;
            while ((charRead = isr.read(inputBuffer)) > 0) {
                String readString = String.copyValueOf(inputBuffer, 0,
                        charRead);
                dataToRead += readString;
                inputBuffer = new char[100];
            }

            String Ceck = dataToRead;
            if (!Ceck.equals(""))
            {
                String[] tmp = Ceck.split("\r\n");
                estxtIP.setText(tmp[0]);
                estxtUserCounter.setText(tmp[1]);
                estxtNomorCounter.setText(tmp[2]);

               // }

            }

        } catch (IOException e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
        }

        alert.setCancelable(false);
        alert.setNegativeButton("Cancel", new DialogInterface.OnClickListener() {

            @Override
            public void onClick(DialogInterface dialog, int which) {
                // load_data_save();
                Toast.makeText(getBaseContext(), "Cancel", Toast.LENGTH_SHORT).show();
            }
        });

        alert.setPositiveButton("Submite", new DialogInterface.OnClickListener() {

            @Override
            public void onClick(DialogInterface dialog, int which) {
                if ((!(estxtIP.getText().equals(""))) && (!(estxtNomorCounter.getText().equals(""))) && (!(estxtUserCounter.getText().equals("")))) {
                    String lstLayanan ="1";
                    final String data_IP;
                    final String data_Name;
                    final String data_Counter;
                    data_IP = estxtIP.getText().toString().trim();
                    data_Name = estxtUserCounter.getText().toString().trim();
                    data_Counter = estxtNomorCounter.getText().toString().trim();
                    listLayanan = layID.toString() ;
                    // listLayanan = esSpnerLayanan.getItemAtPosition(0).toString();//esSpnerLayanan.getCount();
                    //  Toast.makeText(getBaseContext(), listLayanan,
                    //      Toast.LENGTH_SHORT).show();
                  /*  if (listLayanan == null) {
                        lstLayanan = "3";
                    } else if (listLayanan != null) {
                        try
                        {
                             lstLayanan = layID.toString().trim();
                        }
                        catch (RuntimeException ex)
                        {

                        }

                    }*/
                    //Toast.makeText(getBaseContext(), "Layanan :" + listLayanan,
                        //    Toast.LENGTH_SHORT).show();
                    String dataToSave = data_IP + "\r\n" + data_Name + "\r\n" + data_Counter + "\r\n" + listLayanan;
                    try {
                        FileOutputStream fos = openFileOutput("ClientSetting.ini",
                                MODE_WORLD_WRITEABLE);
                        OutputStreamWriter osw = new OutputStreamWriter(fos);
                        // write the string to the file
                        osw.write(dataToSave);
                        osw.flush();
                        osw.close();
                        // success message
                        //Toast.makeText(getBaseContext(), "File saved successfilly" + "\r\n" + "Close and Restart Software",
                         //       Toast.LENGTH_SHORT).show();
                        alertDialog();
                         // clears the EditText
                        // ip_data.setText("");
                        // name_data.setText("");
                    } catch (IOException e) {
                        e.printStackTrace();
                    }
                }

            }
        });
        AlertDialog dialog = alert.create();
        dialog.show();

    }
    public void displayTransfer() {
        LayoutInflater inflater = getLayoutInflater();
        View alertLayout = inflater.inflate(R.layout.transfer_layout, null);
        final Spinner esSpnerLayanan = (Spinner) alertLayout.findViewById(R.id.spnLynTrns);
        final EditText nomorTrns= (EditText)alertLayout .findViewById(R.id.txtNmTrns);
        final List<String> layList = new ArrayList<String>();
        AlertDialog.Builder alert = new AlertDialog.Builder(this);
        alert.setTitle("Transfer Nomor");
        alert.setView(alertLayout);
       try
       {
           final String nmLayanan[]=NamaLayanan;
           for(String x:nmLayanan )
           {
               layList .add(x);
              // Toast.makeText(getBaseContext(),x, Toast.LENGTH_SHORT).show();
               ArrayAdapter<String> adapter = new ArrayAdapter<String>(getApplicationContext() ,android.R.layout.simple_spinner_item ,layList);
               adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
               // Set the adapter to th spinner
               esSpnerLayanan.setAdapter(adapter);
           }
       }
       catch (RuntimeException ex)
       {

       }

        esSpnerLayanan.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {
                trnID = position + 1;
               /* Toast.makeText(getBaseContext(), trnID.toString() + "\r\n" + "Close and Restart Software",
                        Toast.LENGTH_SHORT).show();*/
            }

            @Override
            public void onNothingSelected(AdapterView<?> parent) {
                //  m_tv.setText("");
            }
        });
        String str = myNomorAntritxt .getText().toString();
       // nomorTrns.setText(str);
        String tmpNomor = str;
        String alpabet = "A";
        String nmbLay = "";
        String newStr = tmpNomor.replace(" ", ",");
        String regex = ",";
        // split the string object
        String[]output = newStr.split(regex);
        alpabet = output [0];
        for(int i=0; i<alpabet.length(); i++){
            nmbLay+= ( (int)alpabet.charAt(i) - 64 );
        }
        String Nomor = output [1];
        String zerotmp = "1";
        if(Integer.parseInt(Nomor) <10)
        {
            zerotmp = Nomor.replaceFirst("000", "");
        }
        else if(Integer.parseInt(Nomor) < 100 && Integer.parseInt(Nomor) > 9)
        {
            zerotmp = Nomor.replaceFirst("00", "");
        }
        else if(Integer.parseInt(Nomor) >99)
        {
            zerotmp = Nomor.replaceFirst("0", "");
        }
        nomorTrns.setText(zerotmp);
        alert.setCancelable(false);
        alert.setNegativeButton("Cancel", new DialogInterface.OnClickListener() {

            @Override
            public void onClick(DialogInterface dialog, int which) {
                Toast.makeText(getBaseContext(), "Cancel", Toast.LENGTH_SHORT).show();
            }
        });

        alert.setPositiveButton("Submite", new DialogInterface.OnClickListener() {

            @Override
            public void onClick(DialogInterface dialog, int which) {
                final Integer layTujuan;
                final Integer nomorTrn;
                layTujuan = trnID ;
                userStatus("Transfer Nomor") ;
                nomorTrn = Integer.parseInt(nomorTrns.getText().toString().trim());
                sendRequest(SendData, "Transfer", CounterName ,Layanan ,Counter, "", "",nomorTrn ,layTujuan );

            }
        });
        AlertDialog dialog = alert.create();
        dialog.show();
    }
    public void alertDialog() {
        AlertDialog.Builder builder1 = new AlertDialog.Builder(this);
        builder1.setTitle("Attention");
        builder1.setMessage("File saved successfilly" + "\r\n" + "Close and Restart Software");
        builder1.setCancelable(true);
        builder1.setNeutralButton(android.R.string.ok,
                new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialog, int id) {
                       /// dialog.cancel();
                        finish();
                    }
                });

        AlertDialog alert11 = builder1.create();
        alert11.show();
    }
    public void disebel_btn()
    {
        try
        {
            myCallbtn .setEnabled(false);
            myCallbtn.setBackgroundResource(R.drawable.call_focus);
            myRecallbtn.setEnabled(false) ;
            myRecallbtn .setBackgroundResource(R.drawable.recall_focus);
            myPendingbtn.setEnabled(false);
            myPendingbtn .setBackgroundResource(R.drawable.pending_focus);
            myCallPendingbtn.setEnabled(false) ;
            myCallPendingbtn .setBackgroundResource(R.drawable.callpending_focus);
            myTransferbtn.setEnabled(false);
            myTransferbtn .setBackgroundResource(R.drawable.transfer_focus);
        }
        catch (RuntimeException ex)
        {

        }
    }
    public void enabel_btn()
{
    try
    {
        myCallbtn .setEnabled(true);
        myCallbtn .setBackgroundResource(R.drawable.call_selector);
        myRecallbtn.setEnabled(true) ;
        myRecallbtn .setBackgroundResource(R.drawable.recall_selector);
        myPendingbtn.setEnabled(true);
        myPendingbtn .setBackgroundResource(R.drawable.pending_selector);
        myCallPendingbtn.setEnabled(true) ;
        myCallPendingbtn .setBackgroundResource(R.drawable.callpending_selector);
        myTransferbtn.setEnabled(true);
        myTransferbtn .setBackgroundResource(R.drawable.transfer_selector);
        mySatrtbtn.setEnabled(true);
        mySatrtbtn .setBackgroundResource(R.drawable.start_selector);
        myFinishbtn .setEnabled(true);
        myFinishbtn .setBackgroundResource(R.drawable.finish_selector);
    }
    catch (RuntimeException ex)
    {

    }
}
    public void operation_btn()
    {
        try
        {
            new CountDownTimer(10000, 500) {
                public void onTick(long millisUntilFinished) {
                    myCallbtn .setEnabled(false);
                    myCallbtn .setBackgroundResource(R.drawable.call_focus);
                    myRecallbtn.setEnabled(false) ;
                    myRecallbtn .setBackgroundResource(R.drawable.recall_focus);
                    myPendingbtn.setEnabled(false);
                    myPendingbtn .setBackgroundResource(R.drawable.pending_focus);
                    myCallPendingbtn.setEnabled(false) ;
                    myCallPendingbtn .setBackgroundResource(R.drawable.callpending_focus);
                    myTransferbtn.setEnabled(false);
                    myTransferbtn .setBackgroundResource(R.drawable.transfer_focus);
                    mySatrtbtn.setEnabled(false);
                    mySatrtbtn .setBackgroundResource(R.drawable.start_focus);
                    myFinishbtn .setEnabled(false);
                    myFinishbtn .setBackgroundResource(R.drawable.finish_focus);
                }
                public void onFinish() {
                    myCallbtn .setEnabled(true);
                    myCallbtn .setBackgroundResource(R.drawable.call_selector);
                    myRecallbtn.setEnabled(true) ;
                    myRecallbtn .setBackgroundResource(R.drawable.recall_selector);
                    myPendingbtn.setEnabled(true);
                    myPendingbtn .setBackgroundResource(R.drawable.pending_selector);
                    myCallPendingbtn.setEnabled(true) ;
                    myCallPendingbtn .setBackgroundResource(R.drawable.callpending_selector);
                    myTransferbtn.setEnabled(true);
                    myTransferbtn .setBackgroundResource(R.drawable.transfer_selector);
                    mySatrtbtn.setEnabled(true);
                    mySatrtbtn .setBackgroundResource(R.drawable.start_selector);
                    myFinishbtn .setEnabled(true);
                    myFinishbtn .setBackgroundResource(R.drawable.finish_selector);
                }
            }.start();

        }
        catch (RuntimeException ex)
        {

        }
    }
}

