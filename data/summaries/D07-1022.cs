This result is consistent with the findings of Petrov et al.(2007) for another approximate parsing task.
N07-1051
With first-order vertical markovization (i.e., annotating each nonterminal with its parent as in Johnson, 1998), accuracy is also at 81.2%.
J98-4004
Random Field The second morphology model, pcrfL, which is based on the same morphological lexicon L, uses a second-order conditional random field (Lafferty et al., 2001) to disambiguate the full sentence by modeling local contexts (Kudo et al., 2004; Smith et al., 2005b).
H05-1060 P05-1003 W04-3230
Until recently, the NLP literature on morphological processing was dominated by the largely non-probabilistic application of finite-state transducers (Kaplan and Kay, 1981; Koskenniemi, 1983; Beesley and Karttunen, 2003) and the largely unsupervised discovery of morphological patterns in text (Goldsmith, 2001; Wicentowski, 2002); Hebrew morphology receives special attention in Levinger et al.(1995), Daya et al.(2004), and Adler and Elhadad (2006).
J01-2001 J95-3004 P06-1084 W04-3246
Take, for example, parsing the Wall Street Journal Penn Treebank, a longstanding task for which highly accurate context-free models stabilized by the year 2000 (Collins, 1999; Charniak, 2000).
A00-2018
Tuning the horizontal markovization of the grammar rules (Klein and Manning, 2003a) had a small, adverse effect on this dataset.
P03-1054
3: pprimeL(vectorm | vectorx) = producttextni=1 pL( vectorMi = vectormi | vectorx)bracehtipupleft bracehtipdownrightbracehtipdownleft bracehtipupright posterior, depends on all of vectorx (7) Similar methods were applied by Matsuzaki et al.(2005) and Petrov and Klein (2007) for parsing under a PCFG with nonterminals with latent annotations.
N07-1051 P05-1010
In the HMM community it 4In prior work involving factored syntax models— lexicalized (Klein and Manning, 2003b) and bilingual (Smith and Smith, 2004)—fpoe,1 was applied, and the asymptotic runtime went to O(n5) and O(n7).
P03-1054 W04-3207
In the case where ˆvectorm = vectorm∗ (or equal up to whitespace) the method is identical to Parseval (and also to Tsarfaty, 2006).
P06-3009
There are also morphological disambiguators designed specifically for Hebrew (Segal, 2000; Bar-Haim et al., 2005).
W05-0706
Tsarfaty (2006) instead indexed by non-whitespace character positions, to deal with segmentation mismatches.
P06-3009
As pointed out by Tsarfaty (2006), joint parsing of morphology and syntax renders this indexing inappropriate, since it assumes the yields of the trees are identical—that assumption is violated if there are any errors in the hypothesized vectorm.
P06-3009
Lately a few supervised disambiguation methods have come about, including hidden Markov models (Hakkani-T¨ur et al., 2000; Hajiˇc et al., 2001), conditional random fields (Kudo et al., 2004; Smith et al., 2005b), and local support vector machines (Habash and Rambow, 2005).
H05-1060 P05-1003 P05-1071 W04-3230
Nonetheless, our conclusions support the argument in Tsarfaty (2006) for more integrated parsing methods.
P06-3009
Space does not permit a full description; the model uses all the features of Smith et al.(2005b) except the “lemma” portion of the model, since the Hebrew Treebank does not provide lemmas.
H05-1060 P05-1003
The closest result is Tsarfaty (2006), which we have not directly replicated.
P06-3009
When both involve high levels of ambiguity, this separation becomes harder to justify, as argued by Tsarfaty (2006).
P06-3009
Since the PCFG model was relatively successful compared to lexicalized models, and is faster to run, we decided to use a vanilla PCFG, denoted Gvan, and a parent-annotated version of that PCFG (Johnson, 1998), denoted Gv=2.
J98-4004
Factored estimation has been quite popular in NLP of late (Klein and Manning, 2003b; Smith and Smith, 2004; Smith et al., 2005a, inter alia).
H05-1060 P03-1054 P05-1003 W04-3207
5). A closely related method, applied by Goodman (1996) is called minimum-risk decoding.
P96-1024
This assumption is very common in multilingual parsing (see, for example, Cowan et al., 2005, and Buchholz et al., 2006).
H05-1100 W06-2920
Measures The “Parseval” measures (Black et al., 1991) are used to evaluate a parser’s phrase-structure trees againstagoldstandard.
H91-1060
There are several available analyzers for Hebrew, including Yona and Wintner (2005) and Segal (2000).
W05-0702
