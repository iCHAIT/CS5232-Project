A ---> Client Hello
B ---> Server Hello
C ---> Certificate, Server Key Exchange, Server Hello Done
D ---> Client Key Exchange, Change Cipher Spec, Encrypted Handshake Message
E ---> New Session Ticket, Change Cipher Spec, Encrypted Handshake Message
F ---> Application Data



Trace 1 - X A B	C D	E F	F F	F F F Y
Trace 2 - X A B	C D	E F	F F	F F	F F	F Y
Trace 3 - X A B	C D	E F	F F	F F	F F	F Y
Trace 4 - X A B	C D	E F	F F	F F	F F	F Y
Trace 5 - X A B	C D	E F	F F	F F	F Y
Trace 6 - X A B	C D	E F	F F	F F	F F	F Y
Trace 7 - X A B	C D	E F	F F	F F	F Y
Trace 8 - X A B	C D	E F	F F	F F	F F	F Y
Trace 9 - X A B	C D	E F	F F	F F	F Y
Trace 10 - X A B C D E F F F F F F Y


