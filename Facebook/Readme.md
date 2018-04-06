Facebook
=========

**Wireshark Filter:** (ip.addr==192.168.1.104 || ip.addr == 31.13.78.35)  && ssl


Before every trace clear cookies and sessions

### Procedure to Follow

1. Perform the following trace navigation at dropbox.com (10 times)

> START > Log in > HOme > Profile > Friends > Yahui SOng Search > Home > STOP

2. Save the 10 pcap wireshark file.

3. Exxport the pcap wireshark files as csv

4. Analyse and assign mapping in excel

5. Final Trace Obtained -

> Trace 1 - X A B C D C D E F E F Y

> Trace 2 - X A A B C D B C D E F E F Y

> Trace 3 - X A B C D E F E F Y

> Trace 4 - X A A B C D B C D E F E F Y

> Trace 5 - X A A A B C D B C D B C D E F E F E F Y

> Trace 6 - X A A B C D B C D E F E F Y

> Trace 7 - X A A B C D B C D E F E F Y

> Trace 8 - X A A B C D B C D E F E F Y

> Trace 9 - X A A B C D B C D E F E F Y

> Trace 10 - X A A B C D B C D E F E F Y



### Mapping Used

> A ---> Client Hello

> B ---> Server Hello

> C ---> Certificate, Server Key Exchange, Server Hello Done

> D ---> Client Key Exchange, Change Cipher Spec, Encrypted Handshake Message

> E ---> New Session Ticket, Change Cipher Spec, Encrypted Handshake Message

> F ---> Application Data