a74 previous results (Chelba and Jelinek, 2000) (Charniak, 2001) (Roark, 2001) show that a grammar-based language model benefits from interpolation with a 3-gram model.
P01-1017
The labeled precision/recall results of our model are much worse than those reported in (Charniak, 2001) and (Roark, 2001).
P01-1017
Strict left-to-right parsing makes it easy to combine with a standard 3-gram at the word level (Chelba and Jelinek, 2000) (Roark, 2001) rather than at sentence level (Charniak, 2001).
P01-1017
2. The parser in (Charniak, 2001) is not a strict left-to-right parser.
P01-1017
One solution would be to apply the maximum entropy estimation technique (MaxEnt (Berger et al., 1996)) to all of the three components of the SLM, or at least to the CONSTRUCTOR.
J96-1002
Recently, such models (Charniak, 2001) (Roark, 2001) have been shown to outperform the SLM in terms of both PPL and WER on the UPenn Treebank and WSJ corpora, respectively.
P01-1017
The SLM was trained on 20M words of WSJ text automatically parsed using the parser in (Ratnaparkhi, 1997), binarized and enriched with headwords and NT/POS tag information as explained in Section 2.2 and Section 3.
W97-0301
The statistical parsing community has used various ways of enriching the dependency structure underlying the parametrization of the probabilistic model used for scoring a given parse tree (Charniak, 2000) (Collins, 1999).
A00-2018
Since the treebank parses allow us to annotate parent information onto the constituents, as Johnson did in (Johnson, 1998), this richer predictive annotation can extend information slightly beyond the left context.
J98-4004
Since the SLM parses sentences bottom-up while the parsers used in (Charniak, 2000), (Charniak, 2001) and (Roark, 2001) are top-down, it’s not clear how to find a direct correspondence between our schemes of enriching the dependency structure and the ones employed above.
A00-2018 P01-1017
Finally, in comparison with the language model in (Roark, 2001) which is based on a probabilistic top-down parser, and with the Bihead/Trihead language models in (Charniak, 2001) which are based on immediate head parsing, our enriched models are less effective in reducing the test data PPL: the best PPL result of (Roark, 2001) on the same experimental setup is 137.3, and the best PPL result of (Charniak, 2001) is 126.1.
P01-1017
