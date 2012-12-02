Recasing To demonstrate the versatility of the factored translation model approach, consider the task of recasing (Lita et al., 2003; Wang et al., 2006).
N06-1001
Our framework is more general and goes beyond recent work on models that back off to representations with richer statistics (Nießen and Ney, 2001; Yang and Kirchhoff, 2006; Talbot and Osborne, 2006) by keeping a more complex representation throughout the translation process.
E06-1006 P06-1122
The feature weights λi in the log-linear model are determined using a minimum error rate training method, typically Powell’s method (Och, 2003).
P03-1021
Och et al.(2004) report minor improvements with linguistic features on a Chinese-English task, Koehn and Knight (2003) show some success in re-ranking noun phrases for German-English.
N04-1021 P03-1040
An extended description of these experiments is in the JHU workshop report (Koehn et al., 2006).
W06-3114
874 6.5 Additional Experiments Factored translation models have also been used for the integration of CCG supertags (Birch et al., 2007), domain adaptation (Koehn and Schroeder, 2007) and for the improvement of English-Czech translation (Bojar, 2007).
P07-2045 W07-0702 W07-0733 W07-0735
The English–German systems were trained on the full 751,088 sentence Europarl corpus and evaluated on the WMT 2006 test set (Koehn and Monz, 2006).
W06-3114
German morphological analysis andPOStaggingwasdoneusingLoParSchmidtand Schulte im Walde (2000), English POS tagging was done with Brill’s tagger (Brill, 1995), followed by a simple lemmatizer based on tagging results.
C00-2105 J95-4004
This work is implemented as part of the open sourceMoses1 system(Koehnetal.,2007). Weused the default settings for this system.
P07-2045 W07-0733
Structural problems have also been addressed by pre-processing: Collins et al.(2005) reorder the input to a statistical system to closer match the word order of the output language.
P05-1066
If the input language is morphologically richer than the output language, it helps to stem or segment the input in a pre-processing step, before passing it on to the translation system (Lee, 2004; Sadat and Habash, 2006).
N04-4015
The goal of integrating syntactic information into the translation model has prompted many researchers to pursue tree-based transfer models (Wu, 1997; Alshawi et al., 1998; Yamada and Knight, 2001; Melamed, 2004; Menezes and Quirk, 2005; Galley et al., 2006), with increasingly encouraging results.
J97-3002 P01-1067 P04-1083 P06-1121 P98-1006
Generate surface forms given the lemma and linguistic factors Factored translation models build on the phrasebased approach (Koehn et al., 2003) that breaks up the translation of a sentence into the translation of smalltextchunks(so-calledphrases).
P03-1040
We report results on the development test set, which is also the out-of-domain testsetoftheWMT06workshopsharedtask(Koehn and Monz, 2006).
W06-3114
