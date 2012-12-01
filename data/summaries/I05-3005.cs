Because earlier work in many languages including Chinese uses these simple prefix and suffix features (Brants 2000, Ng and Low 2004) we consider this performance (63.66% on unknown words) as our baseline.
A00-1031 W04-3236
The closest result in the literature is Xue et al.(2002), who retrain the Ratnaparkhi (1996) tagger and reach accuracies of 93% using CTB-I.
C02-1145 W96-0213
Following Brants (2000), we extracted 10% of the data from the Penn Treebank Wall Street Journal (WSJ 4 ) and NEGRA5 (Brants et al., 1999) as observation samples to compare to the rest of the corpora.
A00-1031
(Ng and Low 2004, Toutanova et al, 2003, Brants 2000, Ratnaparkhi 1996, Samuelsson 1993).
A00-1031 N03-1033 W04-3236 W96-0213
Furthermore, it is possible that n-gram features may not be suited to Chinese at all, since Chinese words are much shorter than English (averaging 2.4 characters per word compared with 7.7 for English, for unknown words in CTB 5.0 and Wall Street Journal (Marcus et el., 1993)).
J93-2004
These features have been shown to be useful in previous research on English (Toutanova et al, 2003, Brants 2000, Thede and Harper 1999) The models9 in Table 7 list the different tag sequence features used; they also use the same lexical features from the model 2Rw+2Lw shown in Table 6.
A00-1031 N03-1033 P99-1023
unknown words are those in WSJ 19-21 but unseen in WSJ 0-18; these are the devset and training set from Toutanova et al.(2003). 5 The unknown words of NEGRA are words in a 10% randomly extracted set that were unseen in the rest of the corpus.
N03-1033
Data set Sect'ns Token Unknown Training I 26-270, 600-931 213986 Training II 600-931, 500-527, 1001-1039 204701 Training III 001-270, 301-527, 590-593, 600-1039, 1043-1151 485321 Devset 23839 2849 XH 001-025 7844 381 HKSAR 500-527 8202 1168 SM 590-593, 1001-1002 7793 1300 Test set 23522 2957 XH 271-300 8008 358 HKSAR 528-554 7153 1020 SM 594-596, 1040-1042 8361 1579 5.2 The model Our model builds on research into loglinear models by Ng and Low (2004), Toutanova et al., (2003) and Ratnaparkhi (1996).
N03-1033 W04-3236 W96-0213
Previous work on POS tagging of unknown words has proposed a number of features based on prefixes and suffixes and spelling cues like capitalization (Toutanova et al.2003, Brants 2000, Ratnaparkhi 1996).
A00-1031 N03-1033 W96-0213
But these features have mainly been tested on inflectional languages like English and German, whose derivational and inflectional affixes tend to be a strong indicator of word classes; Brants (2000), for example, showed that an English word ending in the suffix -able was very likely to be an adjective.
A00-1031
However, our performance on tagging when trained on Training I and tested on just the XH part of the test set is 94.44%, which might be a more relevant comparison to Xue et al.(2002). 6 Conclusion Previous research in part-of-speech tagging has resulted in taggers that perform well when the training set and test set are both drawn from the same corpus.
C02-1145
The XH test data we selected was identical to the test set used in previous parsing research by Bikel and Chiang (2000).
W00-1201
