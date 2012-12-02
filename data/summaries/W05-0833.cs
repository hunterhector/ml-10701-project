Accordingly, in this section we describe a set of experiments which extends the work of (Way and Gough, 2005) by evaluating the Marker-based EBMT system of (Gough & Way, 2004b) against a phrase-based SMT system built using the following components: • Giza++, to extract the word-level correspondences; • The Giza++ word alignments are then refined and used to extract phrasal alignments ((Och & Ney, 2003); or (Koehn et al., 2003) for a more recent implementation); • Probabilities of the extracted phrases are calculated from relative frequencies; • The resulting phrase translation table is passed to the Pharaoh phrase-based SMT decoder which along with SRI language modelling toolkit5 performs translation.
J03-1002 N03-1017 P03-1021
performing bootstrap-resampling on the test set (Koehn, 2004)), or re-test with different sample test sets in order to investigate whether the same phenomenon is observed.
W04-3250
From its very inception EBMT has made use of a range of sub-sentential data – both phrasal and lexical – to perform translations whereas, until quite recently, SMT models of translation were based on the relatively simple word alignment models of (Brown et al., 1990).
J90-2002
Until quite recently, SMT models of translation were based on the simple word alignment models of (Brown et al., 1990).
J90-2002
In order to create the necessary SMT language and translation models, they used: • Giza++ (Och & Ney, 2003);2 • the CMU-Cambridge statistical toolkit;3 • the ISI ReWrite Decoder.4 Translation was performed from English–French and French–English, and the resulting translations were evaluated using a range of automatic metrics: BLEU (Papineni et al., 2002), Precision and Recall 2http://www.isi.edu/∼och/Giza++.html 3http://mi.eng.cam.ac.uk/∼prc14/toolkit.html 4http://www.isi.edu/licensed-sw/rewrite-decoder/ 185 (Turian et al., 2003), and Wordand Sentence Error Rates.
J03-1002 P02-1040 P03-1021
(Koehn et al., 2003); (Och, 2003)).
J03-1002 N03-1017 P03-1021
We provide results using a range of automatic evaluation metrics: BLEU (Papineni et al., 2002), Precision and Recall (Turian et al., 2003), and Wordand Sentence Error Rates.
P02-1040
