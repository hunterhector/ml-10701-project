For these trials, we used just the one-best output of that model, which is the same as in Charniak (2000).
A00-2018
Also, features of the sort used in our shallow parser could be included in a reranker, such as that in Charniak and Johnson (2005), with a context-free parsing accuracy objective.
P05-1022
Our performance falls 0.6 percentage points below the best published result on the CoNLL-2000 task, and 0.5 percentage points above the performance by Li and Roth (2001) on their task.
W01-0706
Li and Roth demonstrated that their shallow parser, trained to label shallow constituents along the lines of the well-known CoNLL2000 task (Sang and Buchholz, 2000), outperformed the Collins parser in correctly identifying these constituents in the Penn Wall Street Journal (WSJ) Treebank (Marcus et al., 1993).
J93-2004
Of the two parsers we evaluated, the Charniak (2000) parser gave the best performance, which is consistent with its higher reported performance on the context-free parsing task versus other context-free parsers.
A00-2018
task, originally introduced in Ramshaw and Marcus (1995) and also described in (Collins, 2002; Sha and Pereira, 2003), brackets just base NP constituents5.
N03-1028 W02-1001 W95-0107
To this end, we replicated the NP-chunker described in Sha and Pereira (2003) and trained it as either an NP-chunker or with the tagset extended to classify all 11 phrase types included in the CoNLL-2000 task (Sang and Buchholz, 2000).
N03-1028
to Domain Shift Our final shallow parsing task was also proposed in Li and Roth (2001).
W01-0706
We follow Collins (2002) and Sha and Pereira (2003) in using section 21 as a heldout set.
N03-1028 W02-1001
See (Sha and Pereira, 2003) for more details on this approach.
N03-1028
mentation of the Collins parser and the n-best version of the Charniak (2000) parser, documented in Charniak and Johnson (2005), fit the requirements.
A00-2018 P05-1022
All data was tagged with the Brill POS tagger (Brill, 1995) after the chunklink conversion.
J95-4004
The Collins parser is provided with part-ofspeech tags output by the Brill tagger (Brill, 1995).
J95-4004
The one-best performance of the parser is the same as what was presented in Charniak (2000).
A00-2018
Table 1 shows baseline results for the Li and Roth3 shallow parser, two well-known, highaccuracy context-free parsers, and the reference (true) parses after being modified as described 3We were unable to obtain the exact model used in Li and Roth (2001), and so we use their reported results here.
W01-0706
The third task, introduced by Li and Roth (2001), performs the same labeling as in the CoNLL-2000 task, but with more training data and different testing sets: training was WSJ sections 2-21 and test was section 00.
W01-0706
As mentioned earlier, we used the version of this parser with improved n-best extraction, as documented in Charniak and Johnson (2005), although without the reranking of the candidates that they also report in that paper.
P05-1022
Results 3.1 Comparing Finite-State and Context-Free Parsers The first two rows of Table 3 present a comparison between the SPRep shallow parser and the Charniak (2000) context-free parser detailed in Charniak and Johnson (2005).
A00-2018 P05-1022
In the trials reported in Li and Roth (2001), both of the evaluated systems were provided with reference POS tags from the Switchboard Treebank.
W01-0706
Again, the best-scoring candidate using this composite score is selected from among the shallow 791 NP-Chunking CoNLL-2000 Li & Roth task Punctuation Punctuation Punctuation System Leave Ignore Leave Ignore Leave Ignore SPRep averaged perceptron 94.21 94.25 93.54 93.70 95.12 95.27 Charniak (2000) 94.17 94.20 93.77 93.92 95.15 95.32 Unweighted intersection 95.13 95.16 94.52 94.64 95.77 95.92 Weighted intersection 95.57 95.58 95.03 95.16 96.20 96.33 Table 3: F-measure shallow bracketing accuracy on three shallow parsing tasks, for the SPRep perceptron shallow parser, the Charniak (2000) context-free parser, and for systems combining the SPRep and Charniak system outputs.
A00-2018
Bikel. 2004.
J04-4004
Parser In addition to the trainable n-best context-free parser from Charniak (2000), we needed a trainable shallow parser to apply to the variety of tasks we were interested in investigating.
A00-2018
Sha and Pereira (2003) noted that the difference between their perceptron and CRF results was not significant, and our performance falls between the two, thus replicating their result within noise.
N03-1028
In addition to the clear efficiency benefit of shallow parsing, Li and Roth (2001) have further claimed both an accuracy and a robustness benefit versus context-free parsing.
W01-0706
Systems include our shallow parser (SPRep); the Charniak and Johnson (2005) system (C & J), both initial one-best and reranked-best; and the weighted intersection between the reranked 50-best list and the SPRep system.
P05-1022
They mention that the resulting shallow parse tags are somewhat different than those used by Ramshaw and Marcus (1995), but that they found no significant accuracy differences in training on either set.
W95-0107
We use the averaged perceptron algorithm, as presented in Collins (2002), to train the parser.
W02-1001
Replacing the POS tags in the input text with Brill POS tags before the 5We follow Sha and Pereira (2003) in deriving the NP constituents from the CoNLL-2000 data sets, by replacing all nonNP shallow tags with the “outside” (“O”) tag.
N03-1028
Collins (2000) reported a reranking model that improved his parser output to roughly the same level of accuracy as Charniak (2000), and Charniak and Johnson (2005) report an improvement using reranking over Charniak (2000).
A00-2018 P05-1022
Both the Bikel (2004) imple789 System NP-Chunking CoNLL-2000 Li & Roth task SPRep averaged perceptron 94.21 93.54 95.12 Kudo and Matsumoto (2001) 94.22 93.91 Sha and Pereira (2003) CRF 94.38 Voted perceptron 94.09 Zhang et al.(2002) 94.17 Li and Roth (2001) 93.02 94.64 Table 2: Baseline results on three shallow parsing tasks: the NP-Chunking task (Ramshaw and Marcus, 1995); the CoNLL-2000 Chunking task (Sang and Buchholz, 2000); and the Li & Roth task (Li and Roth, 2001), which is the same as CoNLL-2000 but with more training data and a different test section.
J04-4004 N01-1025 N03-1028 W01-0706 W95-0107
To compare the output of their shallow parser with the output of the well-known Collins (1997) parser, Li and Roth applied the chunklink conversion script to extract the shallow constituents from the output of the Collins parser on WSJ section 00.
P97-1003
Analysis To determine the effects of the conversion routine and different evaluation conventions, we compare the performance of several different models on one of the tasks presented in Li and Roth (2001).
W01-0706
Li and Roth (2001) results are as reported in their paper, with reference POS tags rather than Brill-tagger POS tags.
W01-0706
The output of a contextfree parser, such as that of Collins (1997) or Charniak (2000), can be transformed into a sequence of shallow constituents for comparison with the output of a shallow parser.
A00-2018 P97-1003
Note that the systems used here are exactly the ones presented for the original Li & Roth task, in SecPunctuation System Leave Ignore Li & Roth (reference tags) 88.47 SPRep avg perceptron Reference tags 91.37 91.86 Brill tags 87.94 88.42 Charniak (2000) 87.94 88.44 Unweighted intersection 88.66 89.16 Weighted intersection 89.22 89.69 Table 4: Shallow bracketing accuracy of several different systems, trained on sections 2-21 of WSJ Treebank and applied to section 4 of the Switchboard Treebank.
A00-2018
Evaluation scenario (a) in Table 1 corresponds to what was used in Li and Roth (2001) following CoNLL-2000 guidelines, with the original chunklink script used to transform the contextfree parser output into shallow constituents.
W01-0706
Finite-State and Context-Free Parsers It is likely true that a context-free parser which has been optimized for global parse accuracy will, on occasion, lose some shallow parse accuracy to satisfy global structure constraints that do not constrain 7Sha and Pereira (2003) reported the Kudo and Matsumoto (2001) performance on the NP-Chunking task to be 94.39 and to be the best reported result on this task.
N01-1025 N03-1028
Heterogeneous Parser Output Two commonly reported shallow parsing tasks are Noun-Phrase (NP) Chunking (Ramshaw and Marcus, 1995) and the CoNLL-2000 Chunking task (Sang and Buchholz, 2000), which extends the NPChunking task to recognition of 11 phrase types1 annotated in the Penn Treebank.
W95-0107
The Charniak and Johnson (2005) system output (denoted C & J in the table) before reranking (denoted one-best) is identical to the Charniak (2000) results that have been reported in the other tables.
A00-2018 P05-1022
Finite-state parsing (also called chunking or shallow parsing) has typically been motivated as a fast firstpass for – or approximation to – more expensive context-free parsing (Abney, 1991; Ramshaw and Marcus, 1995; Abney, 1996).
W95-0107
Perhaps the most widely accepted convention is that of ignoring punctuation for the purposes of assigning constituent span, under the perspective that, fun788 Phrase Evaluation Scenario System Type (a) (b) (c) “Modified” All 98.37 99.72 99.72 Truth VP 92.14 98.70 98.70 Li and Roth All 94.64 (2001) VP 95.28 Collins (1997) All 92.16 93.42 94.28 VP 88.15 94.31 94.42 Charniak All 93.88 95.15 95.32 (2000) VP 88.92 95.11 95.19 Table 1: F-measure shallow bracketing accuracy under three different evaluation scenarios: (a) baseline, used in Li and Roth (2001), with original chunklink script converting treebank trees and context-free parser output; (b) same as (a), except that empty subject NPs are inserted into every unary S→VP production; and (c) same as (b), except that punctuation is ignored for setting constituent span.
A00-2018 P97-1003 W01-0706
We follow Li and Roth (2001) in using chunklink to also convert trees output by a context-free parser into a flat representation of shallow constituents.
W01-0706
This affects some parsers more than others, depending on how the parser treats punctuation internally; for example, Bikel (2004) documents that the Collins parser raises punctuation nodes within the parse tree.
J04-4004
