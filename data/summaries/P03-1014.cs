Similar results were reported in (Daum et al., 2003) for integration of chunkand dependency parsing.
E03-1052
(Becker and Frank, 2002) explored a corpusbased stochastic approach to topological field parsing, by training a non-lexicalised PCFG on a topological corpus derived from the NEGRA treebank of German.
C02-1093
With the advent of XML-based hybrid shallowdeep architectures as presented in (Grover and Lascarides, 2001; Crysmann et al., 2002; Uszkoreit, 2002) it has become possible to integrate the added value of deep processing with the performance and robustness of shallow processing.
P01-1034 P02-1056
We thus employ tree entropy as a 9 Further measures are conceivable: We could extract brackets from some n-best topological parses, associating them with weights, using methods similar to (Carroll and Briscoe, 2002).
C02-1013
This compares to a speed-up factor of 2.26 reported in (Daum et al., 2003), by integration of PoS guidance into a dependency parser.
E03-1052
setup We randomly split the manually corrected evaluation corpus of (Becker and Frank, 2002) (for sentence length AK BGBC) into a training set of 600 sentences and a test set of 408 sentences.
C02-1093
While integration in (Grover and Lascarides, 2001) was still restricted to morphological and PoS information, (Crysmann et al., 2002) extended shallow-deep integration at the lexical level to lexico-semantic information, and named entity expressions, including multiword expressions.
P01-1034 P02-1056
By extracting spans for clausal fragments from topological parses, in case of deep parsing fail15 (Daum et al., 2003) report a gain of factor 2.76 relative to a non-PoS-guided baseline, which reduces to factor 1.21 relative to a PoS-prioritised baseline, as in our scenario.
E03-1052
More specifically, we combine a probabilistic topological field parser for German (Becker and Frank, 2002) with the HPSG parser of (Callmeier, 2000).
C02-1093
The architecture employed in this paper improves on (Crysmann et al., 2002) by providing a central Whiteboard Annotation Transformer (WHAT) that supports flexible and powerful access to and transformation of XML annotation based on standard XSLT engines 6 (see (Sch¨afer, 2003) for more details on WHAT).
P02-1056
Yet, due to its linguistic underpinning, the topological tree can be used to systematically predict key constituents in the corresponding ‘target’ HPSG 2 See Section 6 for comparison to recent work on integrated chunk-based and dependency parsing in (Daum et al., 2003).
E03-1052
3 As, for example, in (Duchier and Debusmann, 2001).
P01-1024
It is a useful measure to assess how certain the parser is about the best analysis, e.g. to measure the training utility value of a data point in the context of sample selection (Hwa, 2000).
W00-1306
(Crysmann et al., 2002) assume a vertical, ‘pipeline’ scenario where shallow NLP tools provide XML annotations that are used by the DNLP system as a preprocessing and lexical interface.
P02-1056
9 4.1 Conf D4D6 : Accuracy of map-constraints To determine a measure of ‘expected accuracy’ for the map constraints, we computed precision and recall for the 34 bracket types by comparing the extracted brackets from the suite of best delivered topological parses against the brackets we extracted from the trees in the manually annotated evaluation corpus in (Becker and Frank, 2002).
C02-1093
3.2 Annotation-based Integration In the annotation-based architecture of (Crysmann et al., 2002), XML-encoded analysis results of all components are stored in a multi-layer XML chart.
P02-1056
