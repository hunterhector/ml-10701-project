It is an adaptation of the approach described by Yarowsky and Ngai (2001).
N01-1026
Following the work of Yarowsky and Ngai (2001) we focus on the task of training a Part-of-Speech (POS) tagger, but we conduct our experiments with the more dissimilar language pair of EnglishChinese instead of English-French.
N01-1026
For comparability with Tproj (which assumes no availability of manually annotated data), most experimental results are reported with respect to the reduced Core Tag gold standard; evaluation against the full 33 CHTB tag gold standard is reported in Section 4.4. 4.1 Tagger Trained from Projected Data To determine the quality of Tproj for Chinese, we replicate the POS-tagging experiment in Yarowsky and Ngai (2001).
N01-1026
Co-training has been applied to a number of NLP applications, including POS-tagging (Clark et al., 2003), parsing (Sarkar, 2001), word sense disambiguation (Mihalcea, 2004), and base noun phrase detection (Pierce and Cardie, 2001).
N01-1023 W01-0501 W03-0407 W04-2405
More recently, Smith and Smith (2004) proposed to merge an English parser, a word alignment model, and a Korean PCFG parser trained from a small number of Korean parse trees under a unified log linear model.
W04-3207
Following Yarowsky and Ngai (2001), we define 12 equivalence classes over the 47 Penn-EnglishTreebank POS tags.
N01-1026
Smith. 2004.
W04-3207
Theoretically, it is well-known that two languages often do not express the same meaning in the same way (Dorr, 1994).
J94-4004
Yarowsky (1995) used this method for word sense disambiguation.
P95-1026
Given the parallel corpus, we tagged the English words with a publicly available maximum entropy tagger (Ratnaparkhi, 1996), and we used an implementation of the IBM translation model (AlOnaizan et al., 1999) to align the words.
W96-0213
It has been suggested that annotated data for these languages might be automatically created by leveraging parallel corpora and high-accuracy English systems (Yarowsky and Ngai, 2001; Diab and Resnik, 2002).
N01-1026 P02-1033
Active learning also has been applied to many NLP applications, including POS tagging (Engelson and Dagan, 1996) and pars852 ing (Baldridge and Osborne, 2003).
P96-1042 W03-0403
This algorithm is described in Figure 1, 3.3 Basic POS Tagging Model It is well known that a POS tagger can be trained with an HMM (Weischedel et al., 1993).
J93-2006
Data One method of acquiring a large corpus of automatically POS tagged Chinese data is by projection (Yarowsky and Ngai, 2001).
N01-1026
Dorr. 1994.
J94-4004
Previous research on resource projection attempts to address these problems by redistributing the parameter values (Yarowsky and Ngai, 2001) or by applying transformation rules (Hwa et al., 851 2002).
N01-1026 P02-1050
Finally, the work that is the closest to ours in spirit is the idea of joint estimation (Smith and Smith, 2004).
W04-3207
