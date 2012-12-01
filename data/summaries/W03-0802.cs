The only comparable architecture so far was described by Grover et al.(2002), but their integration was limited to tokenization and PoS tagging (the shallow chunker did not guide or contribute to deep analysis).
W02-1706
LT-XML (Brew et al.2000), XCES (Ide and Romary 2001) and many other are examples for XML-based or XML-supporting software architectures for natural language processing.
P01-1040
Crysmann et al.(2002) and Frank et al.(2003) show that this close deepshallow combination significantly increases robustness and performance compared to the (already fast) standalone deep HPSG parser by Callmeier (2000).
P02-1056
Frank et al.(2003) and Becker and Frank (2002).
C02-1093
Becker and Frank (2002).
C02-1093
We will focus here on the feature structure DTD subset that is able to encode the basic data structures of deep systems such as LKB (Copestake 1999), PET (Callmeier 2000), PAGE, or the shallow system SProUT (Becker et al.2002) which have a subset of TDL (Krieger and Schäfer 1994) as their common basic formalism 2 : <?xml version="1.0" ?> <!-minimal typed feature structure DTD --> <!ELEMENT FS ( F* ) > <!ATTLIST FS type NMTOKEN #IMPLIED coref NMTOKEN #IMPLIED > <!ELEMENT F ( FS ) > <!ATTLIST F name NMTOKEN #REQUIRED > The FS tag encodes typed Feature Structure nodes, F encodes Features.
C02-1093 C94-2144
