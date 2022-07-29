package antsoft.client;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.Spinner;
import android.widget.Toast;


import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.util.ArrayList;
import java.util.List;

import eneter.messaging.endpoints.typedmessages.TypedResponseReceivedEventArgs;

/**
 * Created by Meynin on 25/08/14.
 */
public class config_class extends Activity {
    EditText estxtIP,estxtUserCounter ,estxtNomorCounter;
    Spinner esSpnerLayanan;
    Button btnSaveData,btnCloseSetting;
    public String  listLayanan;
    public String  data_IP;
    public String  data_Name;
    public String  data_Counter;
    public List<String> layList = new ArrayList<String>();
    public void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.display_config);

        ////// UI button
        estxtIP  = (EditText) findViewById(R.id.txtIP);
        estxtUserCounter=(EditText) findViewById(R.id.txtUserCounter);
        estxtNomorCounter=(EditText) findViewById(R.id.txtNomorCounter);
        esSpnerLayanan=(Spinner) findViewById(R.id.spnLayanan);

       /* btnSaveData = (Button) findViewById(R.id.btnSave);
        btnSaveData.setOnClickListener(save_setting);

        btnCloseSetting = (Button) findViewById(R.id.btnClose);
        btnCloseSetting.setOnClickListener(close_setting);*/

        load_data_save();

    }
    ///// Load data internal
    private void load_data_save()
    {
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
              /*  main_class.CcCounter anCCcounter = new main_class.CcCounter() ;
                for(String k:anCCcounter .CCNamaLayanan )
                {
                    layList .add(k);
                    Toast.makeText(getBaseContext(),k, Toast.LENGTH_SHORT).show();
                    ArrayAdapter<String> adapter = new ArrayAdapter<String>(getApplicationContext() ,android.R.layout.simple_spinner_item ,layList);
                    adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
                    // Set the adapter to th spinner
                    esSpnerLayanan.setAdapter(adapter);
                }*/


              //  }
               // listLayanan  = tmp[3];

                               /*Toast.makeText(getBaseContext(),
                        "File loaded successfilly", Toast.LENGTH_SHORT)
                        .show();*/
            }

         /*   List<CharSequence> choices = new ArrayList<CharSequence>();
            choices.add("Earth");
            choices.add("Mars");
            choices.add("Venus");
            choices.add("Jupiter");
            choices.add("Mercury");
            choices.add("Uranus");

            // Create an ArrayAdapter with custom choices
            ArrayAdapter<CharSequence> adapter = new ArrayAdapter<CharSequence>(getApplicationContext() ,android.R.layout.simple_spinner_item ,choices);

            // Specify the layout to use when the list of choices appears
            adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);

            // Set the adapter to th spinner
            esSpnerLayanan.setAdapter(adapter); */

        } catch (IOException e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
        }
    }

    ///// Save data internal
    private View.OnClickListener save_setting = new View.OnClickListener()
    {
        @Override
        public void onClick(View v) {
            if ((!(estxtIP.getText().equals(""))) && (!(estxtNomorCounter.getText().equals(""))) && (!(estxtUserCounter.getText().equals(""))))
            {
                data_IP  = estxtIP.getText().toString().trim();
                data_Name  = estxtUserCounter.getText().toString().trim();
                data_Counter  = estxtNomorCounter.getText().toString().trim();
                main_class AdMain = new main_class() ;
                if( AdMain.NamaLayanan  != null)
                {
                   // ArrayAdapter<String> adapter = new ArrayAdapter<String>(this,AdMain.NamaLayanan.length);
                   // esSpnerLayanan.setAdapter(adapter) ;
                }

                String dataToSave = data_IP + "\r\n" + data_Name + "\r\n" + data_Counter ;
                try {
                    FileOutputStream fos = openFileOutput("ClientSetting.ini",
                            MODE_WORLD_WRITEABLE);
                    OutputStreamWriter osw = new OutputStreamWriter(fos);
                    // write the string to the file
                    osw.write(dataToSave);
                    osw.flush();
                    osw.close();
                    // success message
                    Toast.makeText(getBaseContext(), "File saved successfilly",
                            Toast.LENGTH_SHORT).show();
                    Intent intent = new Intent(config_class.this ,main_class.class);
                    intent.addFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP);
                    intent.putExtra("exit", "true");
                    startActivity(intent);
                    // clears the EditText
                    // ip_data.setText("");
                    // name_data.setText("");
                } catch (IOException e) {
                    e.printStackTrace();
                }
            }

        }
    };
    private View.OnClickListener close_setting = new View.OnClickListener()
    {
        @Override
        public void onClick(View v) {
            Intent intent = new Intent(config_class.this ,main_class.class);
            intent.addFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP);
            intent.putExtra("exit", "true");
            startActivity(intent);
        }
    };

}
