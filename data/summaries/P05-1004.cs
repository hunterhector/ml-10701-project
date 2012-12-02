of Speech Tagging and Chunking Our implementation of SEXTANT uses a maximum entropy POS tagger designed to be very efficient, tagging at around 100 000 words per second (Curran and Clark, 2003), trained on the entire Penn Treebank (Marcus et al., 1994).
E03-1071
Curran and Moens (2002b) compared several context extraction methods and found that the shallow pipeline and grammatical relation extraction used in SEXTANT was both extremely fast and produced high-quality results.
P02-1030 W02-0908
Ciaramita and Johnson (2003) found that common nouns missing from WORDNET 1.6 occurred every 8 sentences in the BLLIP corpus.
W03-1022
These are based on those found in (Curran and Clark, 2003).
E03-1071
Ciaramita and Johnson (2003) present a tagger which uses synonym set glosses as annotated training examples.
W03-1022
The WORDNET 1.6 test set consists of several cross-validation sets of 755 nouns randomly selected from the BLLIP training set used by Ciaramita and Johnson (2003).
W03-1022
Curran and Moens (2002a) compared several different similarity measures and found that Grefenstette's weighted JACCARD measure performed the best: min(wgt(w1, r, w ), wgt(w2, r, w )) max(wgt(w1, r, w ), wgt(w2, r, w )) (1) RELATION DESCRIPTION adj dobj iobj nn nnprep subj Table 4: Grammatical relations from SEXTANT against the CELEX lexical database (Minnen et al., 2001)  and is very efficient, analysing over 80 000 words per second.
P02-1030 W02-0908
Hearst and Sch tze (1993) flatten WORDNET into 726 u categories using an algorithm which attempts to minimise the variance in category size.
W93-0106
Table 3: 2 billion word corpus statistics We have tokenized the text using the Grok-OpenNLP tokenizer (Morton, 2002) and split the sentences using MXTerminator (Reynar and Ratnaparkhi, 1997).
A97-1004
Conclusion Our application of semantic similarity to supersense tagging follows earlier work by Hearst and Sch tze (1993) u and Widdows (2003).
N03-1036 W93-0106
Finally, word similarity can be computed from structural features like head-modifier relationships (Grefenstette 1994b; Ruge 1992; Dagan, Marcus, and Markovitch 1993; Pereira, Tishby, and Lee 1993; Dagan, Pereira, and Lee 1994).
J93-2004
Results We have used the WORDNET 1.6 test set to experiment with different parameter settings and have kept the WORDNET 1.7.1 test set as a final comparison of best results with Ciaramita and Johnson (2003).
W03-1022
Caraballo and Charniak (1999) have explored determining noun specificity from raw text.
W99-0609
For lexical FreeNet, Beeferman (1998) adds over 350 000 collocation pairs (trigger pairs) extracted from a 160 million word corpus of broadcast news using mutual information.
W98-0719
Ciaramita and Johnson (2003) implement a supersense tagger based on the multi-class perceptron classifier (Crammer and Singer, 2001), which uses the standard collocation, spelling and syntactic features common in WSD and named entity recognition systems.
W03-1022
Ciaramita et al.(2003) describe how the lex-files can be used as root nodes in a two level hierarchy with the WORDNET synsets appearA considerable amount of research addresses structurally and statistically manipulating the hierarchy of WORDNET and the construction of new wordnets using the concept structure from English.
W03-1022
This approach significantly outperforms the multi-class perceptron on the same dataset based on WORDNET 1.6 and 1.7.1. 1 Introduction Lexical-semantic resources have been applied successful to a wide range of Natural Language Processing (NLP) problems ranging from collocation extraction (Pearce, 2001) and class-based smoothing (Clark and Weir, 2002), to text classification (Baker and McCallum, 1998) and question answering (Pasca and Harabagiu, 2001).
J02-2003
Our evaluation will use exactly the same test sets as Ciaramita and Johnson (2003).
W03-1022
Our implementation uses a maximum entropy chunker which has similar feature types to Koeling (2000) and is also trained on chunks extracted from the entire Penn Treebank using the CoNLL 2000 script.
W00-0729
This technique is similar to Hearst and Sch tze (1993) and Widdows (2003).
N03-1036 W93-0106
We intend to extend our experiments beyond the Ciaramita and Johnson (2003) set to include previous and more recent versions of WORDNET to compare their difficulty, and also perform experiments over a range of corpus sizes to determine the impact of corpus size on the quality of results.
W03-1022
Word Training Test Rare Senses Baseline Frequent Senses ruling 5,482 200 3.5% 60% an authoritative decision to exert control, or influence space 9,136 200 0% 56% area, volume outer space suit/s 7,467 200 12.5% 57% an action or process in a court a set of garments tank/s 3,909 200 4.5% 90% a combat vehicle a receptacle for liquids train/s 4,271 200 1.5% 74% a line of railroad cars to teach vessel/s 1,618 144 13.9% 69% a ship or plane a tube or canal (as an artery) Artificial ambiguous words or pseudowords are a convenient means of testing disambiguation algorithms (Schtitze 1992a; Gale, Church, and Yarowsky 1992).
C92-2070
Using this approach we have significantly outperformed the supervised multi-class perceptron Ciaramita and Johnson (2003).
W03-1022
Ciaramita (2002) has produced a miniWORDNET by manually reducing the WORDNET hierarchy to 106 broad categories.
W02-0903
The only similar performing tool is the Trigrams `n' Tags tagger (Brants, 2000) which uses a much simpler statistical model.
A00-1031
SENTS. WORDS Evaluation Ciaramita and Johnson (2003) propose a very natural evaluation for supersense tagging: inserting the extra common nouns that have been added to a new version of WORDNET.
W03-1022
Curran and Moens (2002a) introduced the TTEST weight function, which is used in collocation extraction.
P02-1030 W02-0908
These categories are used to label paragraphs with topics, effectively repeating Yarowsky's (1992) experiments using the their categories rather than Roget's thesaurus.
C92-2070
Other alternative sets of supersenses can be created by an arbitrary cut through the WORDNET hierarchy near the top, or by using topics from a thesaurus such as Roget's (Yarowsky, 1992).
C92-2070
Widdows (2003) uses a similar technique to insert words into the WORDNET hierarchy.
N03-1036
Ciaramita and Johnson (2003) call the noun lex-file classes supersenses.
W03-1022
We would like to move onto the more difficult task of insertion into the hierarchy itself and compare against the initial work by Widdows (2003) using latent semantic analysis.
N03-1036
Our results significantly outperform Ciaramita and Johnson (2003) on both test sets even though our system is unsupervised.
W03-1022
Ciaramita and Johnson (2003) believe that the key sense distinctions are still maintained by supersenses.
W03-1022
Regardless of whether it takes the form of dictionaries (Lesk 1986; Guthrie et al.1991; Dagan, Itai, and Schwall 1991; Karov and Edelman 1996), thesauri (Yarowsky 1992; Walker and Amsler 1986), bilingual corpora (Brown et al.1991; Church and Gale 1991), or hand-labeled training sets (Hearst 1991; Leacock, Towell, and Voorhees 1993; Niwa and Nitta 1994; Bruce and Wiebe 1994), providing information for sense definitions can be a considerable burden.
C92-2070 W93-0106
Kelly and Stone (1975) consider hand-constructed disambiguation rules; Lesk (1986), Krovetz and Croft (1989), Guthrie et al.(1991), and Karov and Edelman (1996) use on-line dictionaries; Hirst (1987) constructs knowledge bases; Cottrell (1989) uses syntactic and semantic structure encoded in a connectionist net; Brown et al.(1991) and Church and Gale (1991) exploit bilingual corpora; Dagan, Itai, and Schwall (1991) use a bilingual dictionary; Hearst (1991), Leacock, Towell, and Voorhees (1993), Niwa and Nitta (1994), and Bruce and Wiebe (1994) exploit a hand-labeled training set; and Yarowsky (1992) and Walker and Amsler (1986) perform computations based on a hand-constructed semantic categorization of words (Roget's Thesaurus and Longman's subject codes, respectively).
C92-2070 W93-0106
Ciaramita and Johnson (2003) call this supersense tagging and describe a multi-class perceptron tagger, which uses WORDNET's hierarchical structure to create many annotated training instances from the synset glosses.
W03-1022
A final solution would be to consider a large set of the canonical attributes (Curran and Moens, 2002a) to represent each supersense.
P02-1030 W02-0908
Such an approach based on first-order co-occurrence is used, for example, by Hearst and Plaunt (1993) for the representation of tiles or document subunits that are similar to our notion of context.
W93-0106
