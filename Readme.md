Formal Verification of the TLS Protocol
========================================

This project contains two folders -

### Modelling and Simulation

There is a file called `TLS_with_ECDSA_verify_comfirm.csp`, you can open it use PAT directly, and run it. This file verified 5 TLS 1.3 safety properties:

* Establishing the same session key
* Uniqueness  of  session  key
* Secrecy of the session key
* Peer authenticatio
* Perfect forward secrecy (PFS)

### Traffic Analysis

In this fodler we have 4 subfolders. Each folder contains analysis for each social networking website that we studied. Each sub folder contains -

* Final Order txt file that contains state transistions
* Python Script for computing transistion probabilities - this file takes `final_order.txt` as input (for the respective client.)
* Specific PAT Code for generating graph
* Excel sheet containing transistion probability matrix.
* Readme file

We also made our PAT code modular by writing a C# library and consolidating our PAT code to have a single code.

Final file - 

`emulate_network_TLS.pcsp` that uses `read_file.cs` C# code to import transistion probability matrix and generate graph.

IN the final PAT code you just need to set path_index to the relevant file - 

* facebook -> 1
* twitter -> 2
* Dropbox -> 3
* whatsapp -> 4
