While the research of (Marcu et al., 2006) has much in common with the approach proposed here (such as the syntactified target phrases), there remain a number of significant differences.
W06-1606
Among the first to demonstrate improvement when adding recursive structure was (Chiang, 2005), who allows for hierarchical phrase probabilities that handle a range of reordering phenomena in the correct fashion.
P05-1033
Only quite recently have (Chiang, 2005) and (Marcu et al., 2006) shown that incorporating some form of syntactic structure could show improvements over a baseline PBSMT system.
P05-1033 W06-1606
Akin to POS tagging, the process of supertagging an input utterance proceeds with statistics that are based on the probability of a word-supertag pair given their Markovian or local context (Bangalore & Joshi, 1999; Clark & Curran, 2004).
C04-1041
The NIST MT03 test set is used for development, particularly for optimizing the interpolation weights using Minimum Error Rate training (Och, 2003).
J03-1002 P03-1021
One important way of portraying such lexical descriptions is via the supertags devised in the LTAG and CCG frameworks (Bangalore & Joshi, 1999; Clark & Curran, 2004).
C04-1041
Firstly, rather than induce millions of xRS rules from parallel data, we extract phrase pairs in the standard way (Och & Ney, 2003) and associate with each phrase-pair a set of target language syntactic structures based on supertag sequences.
J03-1002 P03-1021
Coming right up to date, (Marcu et al., 2006) demonstrate that ‘syntactified’ target language phrasescanimprovetranslationqualityforChinese– English.
W06-1606
While (Chiang, 2005) avails of structure which is not linguistically motivated, (Marcu et al., 2006) employ syntactic structure to enrich the entries in the phrase table.
P05-1033 W06-1606
For the CCG supertag experiments, we used the CCG supertagger of (Clark & Curran, 2004) and the Edinburgh CCG tools6 to tag the English part of the parallel corpus as well as the CCG supertag language model data.
C04-1041
There are currently two supertagging approaches available: LTAG-based (Bangalore & Joshi, 1999) and CCG-based (Clark & Curran, 2004).
C04-1041
The bidirectional word alignment is used to obtain phrase translation pairs using heuristics presented in 2http://www.fjoch.com/GIZA++.html 289 (Och & Ney, 2003) and (Koehn et al., 2003), and the Moses decoder was used for phrase extraction and decoding.3 Let t and s be the target and source language sentences respectively.
J03-1002 P03-1021
The CCG supertagger (Clark & Curran, 2004) is based on log-linear probabilities that condition a supertagonfeaturesrepresentingitscontext.
C04-1041
Within the field of Machine Translation, by far the most dominant paradigm is Phrase-based Statistical Machine Translation (PBSMT) (Koehn et al., 2003; Tillmann&Xia, 2003).
N03-2036
F. Och, “Minimum Error Rate Training in Statistical Machine Translation”, in Proceedings of ACL 2003, Sapporo, Japan, pp.160–167, 2003.
J03-1002 P03-1021
The bidirectional word alignmentisusedtoobtainlexicalphrasetranslationpairs using heuristics presented in (Och & Ney, 2003) and (Koehn et al., 2003).
J03-1002 P03-1021
