increase [from $50] to $100) temporal topic 3 Semantic Parsing 3.1 Architecture and Classifier Following the architecture of earlier semantic parsers like Gildea and Jurafsky (2002), we treat the semantic parsing task as a 1-of-N classification problem.
J02-3001 P02-1031
Comparison with other parsers: TEST2 40 words LP(%) LR(%) F1(%) Bikel & Chiang 2000 77.2 76.2 76.7 Chiang & Bikel 2002 81.1 78.8 79.9 Levy & Manning 2003 78.4 79.2 78.8 Collins parser 86.4 85.5 85.9 4.2 Semantic parsing using Collins parses In the test set of 113 sentences, there are 3 sentences in which target verbs are given the wrong POS tags, so they can not be used for semantic parsing.
C02-1126 P03-1056 W00-1201
Following Pradhan et al.(2003), we used tinySVM along with YamCha (Kudo and Matsumoto 2000, 2001) as the SVM training and test software.
N01-1025 W00-0730
Collins parser for Chinese The Collins parser is a state-of-the-art statistical parser that has high performance on English (Collins, 1999) and Czech(Collins et al.1999). There have been attempts in applying other algorithms in Chinese parsing (Bikel and Chiang, 2000; Chiang and Bikel 2002; Levy and Manning 2003), but there has been no report on applying the Collins parser on Chinese.
C02-1126 P03-1056 P99-1065 W00-1201
parser, the Collins (1999) parser, ported to Chinese.
P99-1065
Although a project to produce a Chinese PropBank is underway (Xue and Palmer 2003), this data is not expected to be available for another year.
W03-1707
Due to the sparsity of the head word feature, we also use the part-of-speech of the head word, following Surdeanu et al (2003).
P03-1002
roles Semantic roles in the English (Kingsbury et al 2002) and Chinese (Xue 2002) PropBanks are grouped into two major types: (1) arguments, which represent central participants in an event.
C02-1145
We then describe our port of the Collins (1999) parser to Chinese.
P99-1065
For these experiments, we therefore hand-labeled a small corpus following the Penn Chinese Propbank labeling guidelines (Xue, 2002).
C02-1145
In the original formulation for English in Gildea and Jurafsky (2002), it answers the question: Is the NP governed by IP or VP?
J02-3001 P02-1031
"the international Olympic Conference held in Paris" Figure 1 Example of DE construction Since the governing category information is encoded in the path feature, it may be redundant; indeed this redundancy might explain why the governing category feature was used in Gildea & Jurafsky(2002) but not in Gildea and Palmer(2002).
J02-3001 P02-1031
Many of these features required creating an automatic parse; in doing so we showed that the Collins (1999) parser when ported to Chinese achieved the best reported performance on Chinese syntactic parsing.
P99-1065
