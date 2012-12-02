Ambiguous Accuracies from (Li and Li, 2004) words Major MB-D MB-B BB interest 54.6% 54.7% 69.3% 75.5% line 53.5% 55.6% 54.1% 62.7% Ambiguous Our results words #labeled examples LPcosine LPJS interest 4×15=60 80.2±2.0% 79.8±2.0% line 6×15=90 60.3±4.5% 59.4±3.9% 4.3 Experiment 2: LP vs.
J04-1001
Many methods have been proposed to deal with this problem, including supervised learning algorithms (Leacock et al., 1998), semi-supervised learning algorithms (Yarowsky, 1995), and unsupervised learning algorithms (Sch¨utze, 1998).
J98-1006 P95-1026
parallel corpora or untagged monolingual corpora in two languages) (Brown et al., 1991; Dagan and Itai, 1994; Diab and Resnik, 2002; Li and Li, 2004; Ng et al., 2003), (3) bootstrapping sensetagged seed examples to overcome the bottleneck of acquisition of large sense-tagged data (Hearst, 1991; Karov and Edelman, 1998; Mihalcea, 2004; Park et al., 2000; Yarowsky, 1995).
J04-1001 J94-4003 J98-1002 P00-1069 P02-1033 P03-1058 P91-1034 P95-1026 W04-0807 W04-2405
They roughly fall into three categories according to what is used for supervision in learning process: (1) using external resources, e.g., thesaurus or lexicons, to disambiguate word senses or automatically generate sense-tagged corpus, (Lesk, 1986; Lin, 1997; McCarthy et al., 2004; Seo et al., 2004; Yarowsky, 1992), (2) exploiting the differences between mapping of words to senses in different languages by the use of bilingual corpora (e.g.
C92-2070 J04-1001 P04-1036 P97-1009
455-462. Park, S.B., Zhang, B.T., & Kim, Y.T.. 2000.
P00-1069
1% 8.7e-004 ≪ 8.5e-005 ≪ 10% 1.9e-006 ≪ 1.0e-008 ≪ 25% 9.2e-001 ∼ 3.0e-006 ≪ 50% 1.9e-006 ≫ 6.2e-002 ∼ 75% 7.4e-013 ≫ 7.1e-001 ∼ 100% Systems Baseline htsa3 IRST-Kernels nusels Accuracy 55.2% 72.9% 72.6% 72.4% We used three types of features to capture contextual information: part-of-speech of neighboring words with position information, unordered single words in topical context, and local collocations (as same as the feature set used in (Lee and Ng, 2002) except that we did not use syntactic relations).
W02-1006
It has been shown that one sense per discourse property can improve the performance of bootstrapping algorithm (Li and Li, 2004; Yarowsky, 1995).
J04-1001 P95-1026
Bootstrapping Li and Li (2004) used “interest” and “line” corpora as test data.
J04-1001
SENSEVAL-2004. Ng, H.T., Wang, B., & Chan, Y.S.. 2003.
P03-1058
Table 2: Accuracies from (Li and Li, 2004) and average accuracies of LP with c × b labeled examples on “interest” and “line” corpora.
J04-1001
For SVM, we did not perform feature selection on SENSEVAL-3 data since feature selection deteriorates its performance (Lee and Ng, 2002).
W02-1006
between SVM, Bootstrapping and LP For WSD, SVM is one of the state of the art supervised learning algorithms (Mihalcea et al., 2004), while bootstrapping is one of the state of the art semi-supervised learning algorithms (Li and Li, 2004; Yarowsky, 1995).
J04-1001 P95-1026 W04-0807 W04-2405
Lin, D.K.. 1997.
P97-1009
