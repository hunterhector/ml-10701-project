Comparable results in the literature are Schiehlen’s (2004) 81.03% dependency fscore reached on the German NEGRA treebank and Collins et al.’s (1999) 80.0% labelled accuracy on the Czech PDT treebank.
C04-1056 P99-1065
The method can be transferred to plain unlexicalized PCFG (Klein and Manning, 2003) by transforming long rules into a series of binary rules: a0a48a47 a1 a2a50a49 a0 a37a11a10a51a37a11a1 a2 a37a11a1 a2a52a35a15a8a7a53 a49 a0 a37a11a10a13a37a11a1a33a32a54a44a39a8a55a37a11a1a21a32 a53 a47 a1a33a32 a49 a0 a37a11a10a13a37a11a1a33a32a56a37a11a1a33a32a36a35a15a8 a53 a49 a0 a37a11a10a13a37a11a1a9a8a57a37a11a1a21a42 a53 a47a59a58a60a0 a37a11a10a13a37a11a12a18a2a61a37a11a12a18a2a62a35a15a8a56a63a14a12a18a2 a58a60a0 a37a11a10a13a37a11a12a18a32a54a44a39a8a64a37a11a12a18a32a65a63 a47a66a58a60a0 a37a11a10a51a37a11a12a18a32a67a37a11a12a18a32a36a35a15a8a56a63a14a12a18a32 a58a60a0 a37a11a10a13a37a11a12a14a8a64a37a11a12a43a42a7a63 a47 a10 If the bigram symbols a58a60a0 a37a11a10a51a37a11a12 a32 a37a11a12 a32a36a35a15a8 a63 and a49 a0 a37a11a10a13a37a11a1a33a32a56a37a11a1a21a32a41a35a15a8 a53 occur in less than a certain number of rules (50 in our case), we smooth to unigram symbols instead (a58a60a0 a37a11a10a51a37a11a12a68a32a24a63 and a49 a0 a37a11a10a13a37a11a1a21a32 a53 ).
P03-1054
We applied this approach to the shared task (Buchholz et al., 2006) for Arabic (Hajiˇc et al., 2004), Chinese (Chen et al., 2003), Czech (Böhmová et al., 2003), Danish (Kromann, 2003), Dutch (van der Beek et al., 2002), German (Brants et al., 2002), Japanese (Kawata and Bartels, 2000), Portuguese (Afonso et al., 2002), Slovene (Džeroski et al., 2006), Spanish (Civit Torruella and Martí Antonín, 2002), Swedish (Nilsson et al., 2005), Turkish (Oflazer et al., 2003; Atalay et al., 2003), but not Bulgarian (Simov et al., 2005).
W06-2920
So, Collins et al.(1999) proposed a tag classification for parsing the Czech treebank.
P99-1065
Collins (1999) used a lexicalized approach, Schiehlen (2004) used the manually annotated phrasal categories of the treebank.
C04-1056 P99-1065
The usage of special knowledge bases to determine projections of categories (Xia and Palmer, 2001) would have presupposed language-dependent knowledge, so we investigated two other options: Flat rules (Collins et al., 1999) and binary rules.
H01-1014 P99-1065
In cases there were several possible interpretations for a context 234 free rule, we always chose the most frequent one in the training data (Schiehlen, 2004).
C04-1056
Unlexicalized probabilistic context-free parsing is a simple and flexible approach that nevertheless has shown good performance (Klein and Manning, 2003).
P03-1054
Building on past experiments (Schiehlen, 2003), we chose the “nth-tag” representation which consists of three pieces of information: the POS tag of the head, the direction in which the head lies (left or right), and the number of words with the same POS tag between head and dependent.
P03-1015
Finally the placement of punctuation signs has a major impact on the performance of a parser (Collins et al., 1999).
P99-1065
BitPar (Schmid, 2004).
C04-1024
Collins. 1999.
P99-1065
We used a script of Schmid (2006) to Markovize infrequent rules in this manner (i.e.
P06-1023
In this way, the parser can learn to associate the subcategorization requirements of a word with its local syntactic context (Schiehlen, 2004).
C04-1056
Another strategy that is often used in statistical parsing is Markovization (Collins, 1999): Treebanks 1punctuation {$( $” $, $.} adjectives {ADJA ADJD CARD} adverbs {ADV PROAV PTKA PTKNEG PTKVZ PWAV} prepositions {APPR APPO APZR APPRART KOKOM} nouns {NN NE NNE PDS PIS PPER PPOSS PRELS PRF PWS SYM} determiners {ART PDAT PIAT PRELAT PPOSAT PWAT} verb forms {VAFIN VMFIN VVFIN} {VAIMP VVIMP} {VAINF VMINF VVINF} {VAPP VMPP VVPP} {VVIZU PTKZU} clause-like items {ITJ PTKANT KOUS} 233 Ar Ch Cz Da Du Ge Ja Po Sl Sp Sw Tu Bu Best 66.91 89.96 80.18 84.79 79.19 87.34 91.65 87.60 73.44 82.25 84.58 65.68 87.57 Average 59.94 78.32 67.17 76.16 70.73 78.58 85.86 80.63 65.16 73.52 76.44 55.95 79.98 CF (submitted) 44.39 66.20 53.34 76.05 72.11 68.73 83.35 71.01 50.72 46.96 71.10 49.81 – MaxEnt 59.16 61.65 63.28 73.25 64.47 73.94 82.79 80.30 66.27 69.73 72.99 47.16 – combined 61.82 73.34 71.74 79.64 75.51 80.75 88.15 82.43 67.09 71.15 76.88 53.65 – CF+Markov 45.37 70.76 55.14 74.49 72.55 68.87 84.57 71.89 55.16 47.95 71.18 51.64 – CFM+newcl 73.84 62.10 77.76 49.61 – combined 76.84 72.76 82.59 69.38 72.57 – new rules (in %) 7.15 6.03 4.64 7.34 5.03 7.42 5.59 6.69 21.00 9.50 10.14 14.23 Figure 2: Labelled Accuracy Results on the Test Sets Ar Ch Cz Da Du Ge Ja Po Sl Sp Sw Tu CF 41.91 76.61 52.66 72.77 70.69 70.31 81.36 72.76 49.00 66.93 72.91 65.03 CF+Markov 63.00 80.25 52.80 73.31 70.70 70.51 82.59 74.37 52.43 67.81 73.56 82.80 CFM+newcl 83.07 59.03 80.42 69.30 Figure 3: F Score Results on the Development Sets usually contain very many long rules of low frequency (presumably because inserting nodes costs annotators time).
P99-1065
