Unlexicalized parsers, on the other hand, achieved accuracies almost equivalent to those of lexicalized parsers (Klein and Manning, 2003; Matsuzaki et al., 2005; Petrov et al., 2006).
W03-0428
Comparison with previous best results: KM01 (Kudoh and Matsumoto, 2001), CM03 (Carreras and Marquez, 2003), SP03 (Sha and Pereira, 2003), ZDJ02 (Zhang et al., 2002).
W02-2004
M. Collins, J. Hajic, L. Ramshaw, and C. Tillmann. 1999 A Statistical Parser for Czech. In Proceedings of ACL pages 505512.
W99-0613
In the rst case, the gazetteers will in most cases improve NER results (Carreras et al., 2002) but, unfortunately, they may not exist for a language one is working on.
W02-2004
12 of ENTITY (which will include PHYSICAL ENTITY and ABSTRACT ENTITY).3 4 Experimental Setup 4.1 Corpus and Experimental Expressions We use the British National Corpus (BNC),4 automatically parsed using the Collins parser (Collins, 1999), and further processed with TGrep2.5 We select our potential experimental expressions from pairs of verb and direct object that have a minimum frequency of 25 in the BNC and that involve one of a predefined list of basic (transitive) verbs.
W99-0613
Given an English sentence, we parse it with the Stanford parser (Klein and Manning, 2003) and then generate paraphrases using the following syntactic transformations: 1.
W03-0428
Michael Collins. 1999. Head-Driven Statistical Models for Natural Language Parsing. Ph.D. thesis, University of Pennsylvania.
W99-0613
Similarly to Conll shared task (Tjong Kim Sang, 2002), we also calculated a baseline by tagging all named entities which occurred in the training set (B2).
W02-2024
We then describe our port of the Collins (1999) parser to Chinese.
W99-0613
methods that can be bootstrapped from a little seed data or a few seed rules (Collins, 1999; Cucerzan, 1999) are highly demanded to automatically annotate the training data.
W99-0613
Work Klein and Manning presented an unlexicalized PCFG parser that eliminated all the lexicalized parameters (Klein and Manning, 2003).
W03-0428
Yarowsky (1995), Collins and Singer (1999), Riloff and Jones (1999)).
W99-0613
Initially we assume when judging the entailment relation that it holds for each T-H pair 1 We are using Minipar (Lin, 1998) and Stanford Parser (Klein and Manning, 2003) as preprocessors, see also sec.
W03-0428
Much of the gain in statistical parsing using lexicalized models comes from the use of a small set of function words (Klein and Manning, 2003).
W03-0428
(Klein and Manning, 2003). Lastly, for the WSJ40
W03-0428
Dependency trees are created by extracting a headword for each node of the syntactic tree, according to the rules used by the parser of Collins (1999), where every subtree represents the modifier information for its root headword.
W99-0613
Previous best results: FIJZ03 (Florian et al., 2003), CN03 (Chieu and Ng, 2003), KSNM03 (Klein et al., 2003).
W03-0428
parser, the Collins (1999) parser, ported to Chinese.
W99-0613
2Sometimes, these types of features are referred to as wordexternal and word-internal (Klein et al., 2003) The feature set of some NER methods (Wu, 2002) also includes part-of-speech information and/or word pre xes and suf xes.
W02-2035 W03-0428
In recent years, many accurate phrase-structure parsers have been developed (e.g., (Collins, 1999; Charniak, 2000)).
W99-0613
First, the semantic head of each constituent is identified using head rules similar to those of Collins (1999) and untyped dependencies are then extracted and labeled with the most specific grammatical relations possible using Tregex rules (Levy and Andrew, 2006).
W99-0613
10Following Collins et al. (1999), we used a coarsened ver-
W99-0613
is Hard There are various characteristics of Slavonic languages1 that make them more difficult for automatic processing, whether shallow or deep, than Germanic and Romance languages.2 The two of them which are most conspicuous, and identified as most problematic, e.g., in (Collins et al., 1999), are rich nominal inflection (2.1) and free word order (2.6).
W99-0613
Dan Klein and Christopher D. Manning. 2003. Accurate unlexicalized parsing. In Proceedings of the Association of Computational Linguistics (ACL).
W03-0428
We use 20,000 sentences randomly selected from the British National Corpus (BNC),4 automatically parsed using the Collins parser (Collins, 1999), and further processed with TGrep2,5 and an NP-head extraction software.6 For 2To our knowledge, the only work that considers selectional preferences of subjects and prepositional phrases as well as direct objects is Brockmann and Lapata (2003).
W99-0613
Collins parser for Chinese The Collins parser is a state-of-the-art statistical parser that has high performance on English (Collins, 1999) and Czech(Collins et al.1999). There have been attempts in applying other algorithms in Chinese parsing (Bikel and Chiang, 2000; Chiang and Bikel 2002; Levy and Manning 2003), but there has been no report on applying the Collins parser on Chinese.
W99-0613
In addition, we would also like to explore the semi-supervised techniques such as co-training and self-training (Collins and Singer, 1999).
W99-0613
In addition, several competitions have been organized, with a focus on multilingual NER (Tjong Kim Sang, 2002).
W02-2024
Collins. 1999.
W99-0613
Dekai Wu et al.2002. Boosting for Named Entity Recognition.In the Proceedings of CoNLL-2002, Taipei, Taiwan .
W02-2035
Many of these features required creating an automatic parse; in doing so we showed that the Collins (1999) parser when ported to Chinese achieved the best reported performance on Chinese syntactic parsing.
W99-0613
The other approach proposed recently makes use of the data extracted from the Web (Talukdar et al., 2006).
W06-2919
A very interesting work on named entity recognition task was reported by Collins et al.(1999) who used only few named entities to bootstrap more.
W99-0613
The best results have been received by applying ensemble methods (Wu, 2002; Florian, 2002; Carreras et al., 2002).
W02-2004 W02-2010 W02-2035
References Carreras et al.2002. Named Entity Extraction using AdaBoost.In the Proceedings of CoNLL-2002, Taipei, Taiwan.
W02-2004
The resulting strings are fed to the Stanford Parser (de Marneffe et al., 2006; Klein and Manning, 2003) with its included pretrained model and options ??retainTmpSubcategories??and ??splitTMP 1??
W03-0428
As in Talukdar?s approach (Talukdar et al., 2006), we expect patterns to provide high precision.
W06-2919
generated by the parsers of Collins (1999) and Char-
W99-0613
It is especially challenging to extract the named entities from the text sources written in languages other than English which, in practice, is supported by the results of the shared tasks on the named entity recognition (Tjong Kim Sang, 2002).
W02-2024
For each of these BIBC expressions, BDBCBC sentences containing its usage were randomly selected from the automatically parsed BNC (Collins, 1999), using the automatic VNC identification method described by FS06.
W99-0613
In our experiments, we have applied the COLLINS (Collins, 1999) parser to generate the syntactic tree of both pieces of text.
W99-0613
In many cases, the combination of these approaches has been shown to improve the performance of a single approach both for controlled indexing (Aronson et al., 2004) and free text indexing (Byrne and Klein, 2003).
W03-0428
Michael Collins and Yoram Singer 1999.
W99-0613
