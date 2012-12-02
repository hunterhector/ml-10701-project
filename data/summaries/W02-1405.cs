As a flnal remark, we want to stress that we see the present study as a flrst step toward the eventual uniflcation of EBMT and SMT, and in this respect we agree with (Marcu, 2001).
P01-1050
SMT mainly became known to the linguistic community as a result of the seminal work of Brown et al.(1993b). Since then, many researchers have invested efiort into designing better models than the ones proposed in the aforementioned article and several new exciting ways have been suggested to attack the problem.
H93-1039 J93-2003
Jean V¶eronis and Philippe Langlais, 2000.
A00-1019
Among them, (Brown et al., 1993a) have proposed a way to exploit bilingual dictionnaries at training time.
H93-1039 J93-2003
In a similar vein, Marcu (2001) investigated how to combine Example Based Machine Translation (EBMT) and SMT approaches.
P01-1050
Och et al.(1999) described an elegant way of integrating automatically acquired probabilistic templates into the translation process, and Nie…en and Ney (2001) did the same for morphological information.
W99-0604
Very recently, Yamada and Knight (2001) described a model in which the noisy-channel takes as input a parsed sentence rather than simple words.
P01-1067
A very similar study but with weaker results is derscribed in (Langlais et al., 2000), in the framework of the TransType project.
A00-1019
At the very least, it would require a fairly precise location of errors in previously translated sentences; and we know from the ARCADE campaign on bilingual alignments, that accurate word alignments are di–cult to obtain (V¶eronis and Langlais, 2000).
A00-1019
(Foster, 2000) investigated maximum entropy models as an alternative to the so-called noisy-channel approach.
P00-1006
For instance, Vogel et al.(1996) succeeded in overcoming the independence assumption made by IBM models by introducing order-1 Hidden Markov alignment models.
C96-2141
statistical engine 2.1 The statistical models In this study, we built an SMT engine designed to translate from French to English, following the noisy-channel paradigm flrst described by (Brown et al., 1993b).
H93-1039 J93-2003
We further reduced the number of transfer parameters (originally 34969331) by applying an algorithm described in Foster (2000); this algorithm basically fllters in the pairs of words with the best gain, where gain is deflned as the difierence in perplexity | measured on a held-out corpus | of a model trained with this pair of words and a model trained without.
P00-1006
We know that better alignment models have been proposed and extensively compared (Och and Ney, 2000).
C00-2163
