Constituency trees are provided by the Charniak-Johnson?s Max-Ent reranking parser (Charniak and Johnson, 2005).
P05-1022
parsers and corpora The Charniak-Lease parser is a statistical constituency parser developed by Charniak and Lease (2005).
P05-1022
This parsing approach is very similar to the one used successfully by Nivre et al.(2006), but we use a maximum entropy classifier (Berger et al., 1996) to determine parser actions, which makes parsing extremely fast.
J96-1002
Maximum Entropy Modeling (MaxEnt) (Berger et al., 1996) and Support Vector Machine (SVM) (Vapnik, 1995) were used to build the classifiers in our solution.
J96-1002
Finally, to assess the practical value of the conversion method and of the BioInfer syntactic annotation in the Stanford scheme, we compare the Charniak-Lease constituency parser2 (Charniak and Lease, 2005) and BioLG,3 an adaptation of LG (Pyysalo et al., 2006), on the newly unified dataset combining the constituency-annotated GENIA Treebank with the dependency-annotated BioInfer corpus.
P05-1022
F-score Method 71.10 MEMMThis paper 72.65 reranking Tsai et al.(2006) 72.98 CRF, post-processing Zhou et al.(2004) 72.55 HMM, SVM, postprocessing, gazetteer Friedrich et al.(2006) 71.5 CRF,gazetteer Okanohara et al.(2006) 71.48 semi-CRF Table 7: Performance comparison on the test set.
P06-1059 W04-1219
Okanohara et al.(2006) applied semiCRFs (Sarawagi and Cohen, 2004), which can treat multiple words as corresponding to a single state.
P06-1059
Importance of the treatment of long names might be implicitly indicated in the performance comparison of the participants of JNLPBA shared task (Kim et al., 2004), where the best performing system (Zhou and Su, 2004) attains their scores by extensive post-processing, which enabled the system to make use of global information of the entity labels.
W04-1219
Shen et al.(2003), Zhang et al.(2004), and Zhou et al.(2004) all report on a rulebased approach to dealing with nested NEs in the GENIA corpus (Version 3.0) in combination with a Hidden Markov Model (HMM) that first recognises innermost NEs.
W04-1219
Our future plans include further sophistication of features, such as the use of external gazetteers which is reported to improve the F-score by 1.0 and 2.7 points in (Zhou and Su, 2004) and (Friedrich et al., 2006), respectively.
W04-1219
The conditional log-linear feature combination framework (Berger, Della Pietra and Della Pietra, 1996) is remarkably simple and effective in practice.
J96-1002
Though it is impossible to observe clear correlation between the performance and classification models or resources used, an important characteristic of the best system by Zhou et al.(2004) seems to be extensive use of rule-based post processing they apply to the output of their classifier.
W04-1219
of the previous studies (Kim et al., 2004; Okanohara et al., 2006; Tzong-Han Tsai et al., 2006), features of shallow parsers had a large contribution to the performance.
P06-1059
References A.Berger, S.A.DellaPietra, andV.J.DellaPietra. 1996.
J96-1002
algorithm similar to that of McClosky et al. (2006).
N06-1020
Eugene Charniak and Mark Johnson. 2005. Coarse-to-fine n-best parsing and maxent discriminative reranking. In ACL 43, pages 173180.
P05-1022
The latter, pipelined systems include a recent study by Krishnan et al.(2006), as well as our reranking system.
P06-1141
We could have partially alleviated this effect by employing head-word triggers as done in Zhou et al.(2004), but we decided to use backward tagging because the results of a number of preliminary experiments, including the ones shown in Table 2 above, seemed to be showing that the backward tagging is preferable in this task setting.
W04-1219
D. McClosky, E. Charniak, and M. Johnson. 2006. Effective Self-Training for Parsing. In Proceedings of HLT-NAACL, pages 152159.
N06-1020
Work In previous work addressing nested entities, Shen et al.(2003), Zhang et al.(2004), Zhou et al.(2004), Zhou (2006), and Gu (2006) considered the GENIA 2Both corpora are represented in XML with standoff annotation, potentionally allowing overlapping NEs.
W04-1219
Charniak. 2005.
P05-1022
In previous research on natural language processing, many methodologies for extracting various relations from corpora have been developed, such as the ?is-a??relation (Hearst 1992), ?part-of??relation (Berland and Charniak 1999), causal relation (Girju 2003), and entailment relation (Geffet and Dagan 2005).
P05-1022
In this paper, we use reranking architecture, which was successfully applied to the task of natural language parsing (Collins, 2000; Charniak and 209 Johnson, 2005), to address the problem.
P05-1022
While Shen et al.(2003) and Zhang et al.(2004) report results testing on 4% of the abstracts in the GENIA corpus, Zhou et al.(2004) report 10-fold cross-validation scores.
W04-1219
been previously explored by McClosky et al. (2006),
N06-1020
(Popovic and Ney, 2004)) or machine translation quality (Nieen and Ney (2001), Koehn and Knight (2003), Zollmann et al.(2006), among others, for various languages; Goldwater and McClosky (2005), Bojar et al.(2006) and Talbot and Osborne (2006) for Czech), however, they focus on translating from the highly inflectional language.
N06-1020
where li is the next BIO tag, li?? is the previous BIO tag, S is the target sentence, and fj and lj are feature functions and parameters of a log-linear model (Berger et al., 1996).
J96-1002
We also plan to apply self-training of n-best tagger which successfully boosted the performance of one of the best existing English syntactic parser (McClosky et al., 2006).
N06-1020
Statistical approaches (Collier et al., 2000; Kazama et al., 2002; Settles, 2004) typically improve recall at the expense of precision, but are more readily retargetable for new nomenclatures and organisms.
W04-1213
