See (Kudo and Matsumoto, 2001) for more information about parameters.
N01-1025
In addition, we split the GENIA 1.1 subset into the test dataset of 80 abstracts used in Kazama et al.(2002)8 and the training dataset of the remaining 590 abstracts.
W02-0301
There are four kinds of chunk tags in the CoNLL-1999 dataset, namely IOB1, IOB2, IOE1, and IOE2 (Tjong Kim Sang and Veenstra, 1999).
E99-1023
Use of a weighted voting of multiple system outputs, as discussed in (Kudo and Matsumoto, 2001), is left for future research.
N01-1025
As 7Results reported in Olsson et al.(2002) are different from the Yapex web site.
C02-1110
Our morphological analyzer for biomedical English, cocab2, is inspired by the work of Yamashita and Matsumoto (2000).
A00-1032
Results of protein name recognition in Kazama et al.(2002) using GENIA 1.1 are 0.492, 0.664 and 0.565 for precision, recall, f-score respectively.
W02-0301
We follow Kudo and Matsumoto (2001) to train four BaseNP recognizers, one for each chunk tag.
N01-1025
e.g. Collins and Singer (1999), would have to be explored.
W99-0613
Previous work in bio-entity (including protein) recognition can be categorized into three approaches: (a) exact and approximate string matching (Hanisch et al., 2003), (b) handcrafted rule-based approaches (Fukuda et al., 1998) (Olsson et al., 2002), and (c) machine learning (Collier et al., 2000), (Kazama et al., 2002).
C00-1030 C02-1110 W02-0301
Our evaluation criteria follow that of Olsson et al.(2002). We calculate the standard measures of precision, recall and f-score for each boundary condition of strict, left, right and sloppy described in Table 4.
C02-1110
Results 3.1 Experiment using Yapex Corpus We first conduct experiments with Yapex corpus5, the same corpus used in Olsson et al.(2002) to get a direct comparison with the good-performing rulebased approach6.
C02-1110
Essentially, our method is the same as Kudo and Matsumoto (2001) in viewing the task as a sequence of classifying each chunk label by SVM.
N01-1025
as Sequential Classification Our protein name tagging is formulated as IOB2/IOE2 chunking (Tjong Kim Sang and Veenstra, 1999).
E99-1023
There are 99 abstracts for training 5http://www.sics.se/humle/projects/prothalt/ 6Olsson et al.(2002) claim they outperform Fukuda et al.(1998) evaluated with Yapex corpus.
C02-1110
