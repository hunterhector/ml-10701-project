For more than a decade, the Penn Treebank’s Wall Street Journal corpus has served as a benchmark for developing and evaluating statistical parsing techniques (Collins, 2000; Charniak and Johnson, 2005).
P05-1022
Most prior work has focused on handling disfluencies and continued to rely on hand-annotated transcripts that include punctuation, case, and known sentence boundaries (Hindle, 1983; Core and Schubert, 1999; Charniak and Johnson, 2001; Engel et al., 2002).
N01-1016 P83-1019 P99-1053 W02-1007
Extensions of Charniak and Johnson (2001) look at using quantized combinations of prosodic features as additional “words”, similar to the use of punctuation in parsing written text (Gregory et al., 2004), but do not find that the prosodic features are useful.
N01-1016 N04-1011
A language model characterizing this dependency with hidden stack operations is proposed in (Heeman and Allen, 1999).
J99-4003
Certainly, prosodic cues are useful for sentence segmentation (Liu et al., 2004), and the quality of automatic segmentation can have a significant impact on parser performance (Kahn et al., 2004).
N04-4032
The primary use of prosody was to rule out candidate parses (Bear and Price, 1990; Batliner et al., 1996).
P90-1003
This reranking step enables incorporation of features based on an earlier word-based classifier (Charniak and Johnson, 2001) in addition to output features of the TAG model.
N01-1016
Of particular mention is the analysis of the relationship between speech repairs and parsing accuracy presented by Charniak and Johnson (2001), as this directly influenced our work.
N01-1016
While we are not the first to employ prosodic cues in a statistical parsing model, previous efforts (Gregory et al., 2004; Kahn et al., 2004) incorporated these features as word tokens and thereby suffered from the side-effect of displacing words in the n-gram models by the parser.
N04-1011 N04-4032
system We adopt an existing parser-reranker as our baseline (Charniak and Johnson, 2005).
P05-1022
Therefore, we evaluated two PCFGs (Bikel, 2004; Charniak and Johnson, 2005) on edit detection and compared their performance to a state-of-the-art TAG-based edit detection system (Johnson et al., 2004).
P05-1022
In evaluating parse accuracy, we adopt the relaxed edited revision (Charniak and Johnson, 2001) to the standard PARSEVAL metric, which penalizes systems that get EDITED spans wrong, but does not penalize disagreements in the attachment or internal structure of edit regions.
N01-1016
3.1 Overall architecture Our architecture, shown in Figure 2, combines the parse reranking framework of (Collins, 2000) with the edit detection and parsing approach of (Charniak and Johnson, 2001).
N01-1016
We validate this claim empirically: two state-of-the-art PCFGs (Bikel, 2004; Charniak and Johnson, 2005) are both shown to perform significantly below a state-of-the-art edit detection system (Johnson et al., 2004).
P05-1022
Alternatively, it could be that including a representation of prosodic features as terminals in (Gregory et al., 2004) displaces words in the parser n-gram model history.
N04-1011
Our system architecture combines earlier models proposed for parse reranking (Collins, 2000) and filtering out edit regions (Charniak and Johnson, 2001).
N01-1016
As was done in (Kahn et al., 2004), we resegmented the treebank’s sentences into V5-style sentence-like units (SUs) (LDC, 2004), since our ultimate goal was to be able to parse speech given automatically detected boundaries.
N04-4032
While it had been claimed that PCFGs perform poorly as edit detectors (Charniak and Johnson, 2001), we could not find empirical evidence in the literature quantifying the severity of the problem.
N01-1016
the impact of automatic segmentation is addressed in other work (Kahn et al., 2004).
N04-4032
