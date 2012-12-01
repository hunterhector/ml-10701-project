We have: )|(),|(),|( )|,,()|( 21 21 trictrictric trictritri erpercpercp ecrcpecp = = (6) Assumption 2: For an English triple tri e, assume that i c only depends on {1,2}) (i ∈ i e, and c r only depends on e r . Equation (6) is rewritten as: )|()|()|( )|(),|(),|()|( 2211 21 ec trietrictrictritri rrpecpecp erpercpercpecp = = (7) Notice that )|( 11 ecp and )|( 22 ecp are translation probabilities within triples, they are different from the unrestricted probabilities such as the ones in IBM models (Brown et al., 1993).
J93-2003
(Cao and Li, 2002) acquire noun phrase translations by making use of web data.
C02-1011 P02-1044
As for collocation translation, Smadja et al.(1996) implement a system to extract collocation translations from a parallel EnglishFrench corpus.
J96-1001
Some studies have been done for acquiring collocation translations using parallel corpora (Smadja et al, 1996; Kupiec, 1993; Echizen-ya et al., 2003).
J93-1007 J96-1001 P93-1003
In addition, (Dagan and Itai, 1994) and (Li, 2002) propose using two monolingual corpora for word sense disambiguation.
J94-4003 P02-1044
pp. 57-63 Dekang Lin 1999.
P99-1041
The former extracts collocations within a fixed window (Church and Hanks 1990; Smadja, 1993).
J90-1003 J93-1007
Melamed (1997) and Lin (1999) have done some research on noncompositional phrases discovery.
P99-1041 W97-0311
(Rapp, 1999) and (Koehn and Knight, 2002) extract new word translations from non-parallel corpus.
P99-1067 W02-0902
baseline experiment, Model A selects the highestfrequency translation for each word in triple; Model B selects translation with the maximal target triple probability, as proposed in (Dagan 1994); Model C selects translation using both language model and translation model, but the translation probability is simulated by a similarity score which is estimated from monolingual corpus using mutual information measure (Zhou et al., 2001).
J94-4003
In addition to collocation translation, there is also some related work in acquiring phrase or term translations from parallel corpus (Kupiec, 1993; Yamamoto and Matsumoto 2000).
C00-2135 P93-1003
(Smadja et al., 1996; Gao et al., 2002; Wu and Zhou, 2003).
J96-1001 P03-1016
These range from twoword to multi-word, with or without syntactic structure (Smadja 1993; Lin, 1998; Pearce, 2001; Seretan et al.2003). In this paper, a collocation refers to a recurrent word pair linked with a certain syntactic relation.
J93-1007
Most previous research in translation knowledge acquisition is based on parallel corpora (Brown et al., 1993).
J93-2003
Some research has been done to expand translation dictionary using a non-parallel corpus (Rapp, 1999; Keohn and Knight, 2002).
P99-1067
(Fung, 1998) uses an IR approach to induce new word translations from comparable corpora.
P98-1069
(Wu and Zhou, 2003) also make full use of large scale monolingual corpora and limited bilingual corpora for synonymous collocation extraction.
P03-1016
