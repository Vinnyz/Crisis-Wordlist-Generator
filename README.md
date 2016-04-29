# Crisis Wordlist Generator

Work on Windows, Debian and Kali Linux. Please reading  <a href="https://github.com/teeknofil/Crisis-Wordlist-Generator/wiki"> Wiki</a>

# Install in Linux

* [Warning, install mono before.](https://youtu.be/9TqwB1mj9_0)

* [Install Crisis Wordlist Generator in Linux](https://youtu.be/88RBHHNkgE0)

# Run
<pre style=" border: 1px solid black; padding:10px">
root@kali:~# crisis 

 Hacking US   : hackforums.net 
 Trouble US   : forums.kali.org
 Hacking FR   : hackademics.fr
 Trouble FR   : kali-linux.fr/forum
 Hacking Wifi : crack-wifi.com/forum


 Crisis Wordlist Generator  by Teeknofil, version : 1.1.2 


 1) 	 CREATE WORDLIST NO JUTSU 

 2) 	 TRANSFORMING WORDLIST NO JUTSU

 3) 	 DOWNLOAD WORDLIST NO JUTSU 	

 99)	 EXIT 

[+]  With what category you want to work :  
</pre>

# Manual

<pre style=" border: 1px solid black; padding:10px">

root@kali:~# crisis -h


Crisis Wordlist Generator by Teeknofil,  version : 1.1.2


SYNOPSIS

crisis [method] -l [len] -f [charset string] [options]

DESCRIPTION

Crisis can create a wordlist based on criteria you specify.
The output  from crisis can be sent to the screen, file,
or  to  another  program.  The required parameters are:

Help:                                                                           
   -h, --help           Shows this help text                                    
   -w,                                                                          
   --help-wordlist      Displays the list of wordlist                           

Method:                                                                         
   -1, --crunch         Charset list customized to crunch wordlist generator.   
                        Example : crisis -1 -l 10 -f ualpha -u                  
   -2, --combination    Generate a character list combination.                  
                        Example : crisis -2 -l 5 -f MyWord -u                   
   -3, --random         Generate random character.                              
                        Example : crisis -3 -l 15 -f mixalpha -u                
   -4, --variation      Generate a character list variation.                    
                        Example : crisis -4 -l 10 -f lalpha                     
   -5, --permutation    Generate a character list permutation.                  
                        Example : crisis -5 -l 10 -f lalpha                     
   -6, --wifi           Generer des caractere specialement                      
                        pour un routeur ou une box                              
                        Exemple :                                               
                        crisis -6 -f livebox-sagem                              
                        crisis -6 -f sfr -u | aircrack-ng                       
                        -e SFR_???? -w- out-01.cap                              

Options:                                                                        
   -b, --byte           Specifies the size of the output file,                  
                         only works if -o is used,  i.e.:  60 mib.              
                        For example  is 500 mib correct 500mb  is NOT correct.  
                        The three types are based on 1024.                      
                        Example : crisis -2 -l 10 -f                            
                        JohnDoe0123456789 -b 50 mib -o will generate 1          
                        files  valid values for type  are   kib, mib, and gib.  
                        NOTE  There is  space between the number and type.      
   -c, --line           Specifies the number of lines to  write  to  output     
                        file,  only works if -o is used.                        
                        Example : crisis -4 -l 10 -f mixalpha -r -o -c 10000 -z 
   -e, --endblock       Specifies a ending string, eg: god77xD.                 
                        Example : crisis -2 -l 16 -f                            
                         sv-mixalpha  -e "Do a barrel roll"                     
   -i, --invert         Inverts  the  output  so  instead  of  aaa,aab,aac,aad, 
                        etc you get aaa,baa,caa,daa,aba,bba, etc                
   -o, --output         Specify the save file in the                            
                        crisis folder on the desktop                            
   -r, --repeat         Specify if you want a repetition of characters.         
                        Example : crisis -5 -l 10 -f  sv-mixalpha  -r           
   -s, --startblock     Specifies a starting string, eg: qwerty.                
                        Example : crisis -2 -l 15 -f                            
                         sv-mixalpha  -s "Hello World"                          
   -u, --disables       The -u option disables the print size .                 
                        This should be the last option.                         
   -z, --zip            Compresses  the output from the -o option.              
                        Example : crisis -2 -l 10 -f                            
                        ualpha -r  -o  -b 1024 mib -z                           

Parameter:                                                                      
   -f, --charset-name   Specifies a character set from crisis,                  
                        type --help-wordlist for more info                      
   -l, --lenght         Number of character or character group    
</pre>

#Usage

<h2>Pipe with Aircrack-ng</h2>

<pre style=" border: 1px solid black; padding:10px">
./crisis.exe -3 -l 20  -f lalpha-numeric | aircrack-ng -w- -e BOX__XXXX output-01.cap 
Opening output-01.cap
Opening output-01.cap
Reading packets, please wait...

                                 Aircrack-ng 1.2 rc2


                   [00:11:20] 1268865 keys tested (1870.62 k/s)


                       Current passphrase: 3e4u74mem30uf1sso47p       


      Master Key     : DF 02 B4 54 4A A5 43 FE BC 5E 09 AB 3C B6 33 70 
                       7E 4A 78 50 4E AA B2 4B C2 C8 3A 1F 31 FC A6 5A 

      Transient Key  : EF AD 2F 48 64 03 60 73 3A 34 03 D9 D3 1D DD B5 
                       F3 F0 1C EF 7C 36 15 6B 57 4C 43 3B 64 40 30 F5 
                       9F 35 70 36 C8 6F E7 E7 71 BE 01 42 96 A0 90 33 
                       2B B9 CF 3B 1B B5 27 AA 75 14 D1 4E 09 70 EF F4 

      EAPOL HMAC     : A1 F8 50 CD C8 32 F6 6B C2 86 0B 58 40 B7 3D 24
</pre>

<h2>Pipe with genpmk</h2>

<pre style=" border: 1px solid black; padding:10px">
crisis -3 -l 20 -f lalpha | genpmk -f- -d wordlistBOX -s BOX_XXXX
genpmk 1.1 - WPA-PSK precomputation attack. <jwright@hasborg.com>
Using STDIN for words.
File wordlistSFR does not exist, creating.
key no. 1000: negdhirvdowoyodenjta
key no. 2000: pggcdhupteltboqnzvac
key no. 3000: sxtpwjrcegzmpskultzy
key no. 4000: gwifxtqfvvsttvuowmii
key no. 5000: xxmvqajwzjoyglotainh
key no. 6000: xefzswiqrzcqsbqncugu
key no. 7000: cmuxxhwtbyskclxzlbdq
key no. 8000: fhmegcamdtbwwbvfvdsj
key no. 9000: yeonrqsrvllbdfyvuuqc
key no. 10000: kgrzzjqshhbangsfqezm
^C
10470 passphrases tested in 26.96 seconds:  388.38 passphrases/second
</pre>

<h2>Pipe with cowpatty</h2>

<pre style=" border: 1px solid black; padding:10px">
crisis -3 -l 20 -f lalpha | cowpatty -f- -r output-01.cap -s BOX_XXXX
cowpatty 4.6 - WPA-PSK dictionary attack. <jwright@hasborg.com>

Collected all necessary data to mount crack against WPA2/PSK passphrase.
Starting dictionary attack.  Please be patient.
Using STDIN for words.
key no. 1000: dcqjjuxfzmugiubenvrw
key no. 2000: dgcuvpaltalrtqqffpum
key no. 3000: uvbjybtoygvezmysffbw
key no. 4000: yeuhlbqjvjkbtfgkeogm
key no. 5000: prubwsjmrhqsmpslcqhp
key no. 6000: pkpracuojhawqpetsuqi
^CUnable to identify the PSK from the dictionary file. Try expanding your
passphrase list, and double-check the SSID.  Sorry it didn't work out.

6739 passphrases tested in 16.27 seconds:  414.29 passphrases/second
</pre>
