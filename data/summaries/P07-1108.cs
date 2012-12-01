The data used for this experiment is the same as those used in (Wang et al., 2006).
P06-2112
The translation quality was evaluated using a well-established automatic measure: BLEU score (Papineni et al., 2002).
P02-1040
3 Phrase-Based SMT According to the translation model presented in (Koehn et al., 2003), given a source sentence f, the best target translation best e can be obtained according to the following model )( )()|(maxarg )|(maxarg e e e eef fee length LM best ωpp p = = (1) Where the translation model )|( efp can be decomposed into ∏ = − −= I i i iii i i II aefpbadef efp 1 1 1 1 ),|()()|( )|( λ φ w (2) Where )|( i i efφ and )( 1− − ii bad denote phrase translation probability and distortion probability, respectively.
N03-1017
For the second kind, Niessen and Ney (2004) used morpho-syntactic information for translation between language pairs with scarce resources.
J04-2003
For the subtask of unlimited resources, some researchers (Aswani and Gaizauskas, 2005; Lopez and Resnik, 2005; Tufis et al., 2005) used language-dependent resources such as dictionary, thesaurus, and dependency parser to improve word alignment results.
W05-0812 W05-0819
Borin (2000) and Wang et al.(2006) used pivot languages to improve word alignment.
C00-1015 P06-2112
Callison-Burch et al.(2006) used pivot languages for paraphrase extraction to handle the unseen phrases for phrase-based SMT.
N06-1003
With 50,000 French-Spanish sentence pairs available, the interpolated model significantly 3 improves the translation quality by achieving an absolute im3 We conduct the significance test using the same method as described in (Koehn and Monz, 2006).
W06-3114
Thus, equation (3) can be rewritten as ∑ = i p i iii i i eppfef )|()|()|( φφφ (4) 4.2 Lexical Weight Given a phrase pair ),( ef and a word alignment a between the source word positions ni,...,1= and the target word positions mj,...,1=, the lexical weight can be estimated according to the following method (Koehn et al., 2003).
N03-1017
A shared task on word alignment was organized as part of the ACL 2005 Workshop on Building and Using Parallel Texts (Martin et al., 2005).
W05-0809
We run the decoder with its default settings and then use Koehn's implementation of minimum error rate training (Och, 2003) to tune the feature weights on the development set.
N03-1017 P03-1021
Pivot Language methods were also used for translation dictionary induction (Schafer and Yarowsky, 2002), word sense disambiguation (Diab and Resnik, 2002), and so on.
P02-1033 W02-2026
Wang et al.(2006) induced alignment models by using two additional bilingual corpora to improve word alignment quality.
P06-2112
Borin (2000) used multilingual corpora to increase alignment coverage.
C00-1015
For statistical machine translation (SMT), phrasebased methods (Koehn et al., 2003; Och and Ney, 2004) and syntax-based methods (Wu, 1997; Alshawi et al.2000; Yamada and Knignt, 2001; Melamed, 2004; Chiang, 2005; Quick et al., 2005; Mellebeek et al., 2006) outperform word-based methods (Brown et al., 1993).
J00-1004 J04-4002 J93-2003 J97-3002 N03-1017 P01-1067 P04-1083 P05-1033
∑ = ' ),'( ),( )|( f efcount efcount efw (8) We also estimate the lexical translation probability )|( efw using the method described in (Wang et al., 2006), which is shown in (9).
P06-2112
859 The phrase method proposed in this paper performs better than the word method proposed in (Wang et al., 2006).
P06-2112
on the Europarl Corpus 6.1 Data A shared task to evaluate machine translation performance was organized as part of the NAACL/HLT 2006 Workshop on Statistical Machine Translation (Koehn and Monz, 2006).
W06-3114
Using BLEU (Papineni et al., 2002) as a metric, our method achieves an absolute improvement of 0.06 (22.13% relative) as compared with the standard model trained with 5,000 L f -L e sentence pairs for French-Spanish translation.
P02-1040
