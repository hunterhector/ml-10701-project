The difference lies in that Wu et al.(2005) take all alignment links as sure links.
P05-1058
Based on these two sets, we use a modified "refined" method (Och and Ney, 2000) to construct a pseudo reference set . 1 A 2 A U R (1) The intersection is added to the reference set . 21 AAI ∩= U R (2) We add to if a) is satisfied or both b) and c) are satisfied.
P00-1056
In recent years, many researchers build alignment links with bilingual corpora (Wu, 1997; Och and Ney, 2003; Cherry and Lin, 2003; Wu et al., 2005; Zhang and Gildea, 2005).
J03-1002 J97-3002 P03-1012 P05-1058 P05-1059
The testing set is also manually word aligned, including 8,634 alignment links in the testing set 3 . 5.2 Evaluation Metrics We use the same evaluation metrics as described in Wu et al.(2005), which is similar to those in (Och and Ney, 2000).
P00-1056 P05-1058
Consequently, semi-supervised learning, which combines both labeled and unlabeled data, has been applied to some NLP tasks such as word sense disambiguation (Yarowsky, 1995; Pham et al., 2005), classification (Blum and Mitchell, 1998; Thorsten, 1999), clustering (Basu et al., 2004), named entity classification (Collins and Singer, 1999), and parsing (Sarkar, 2001).
N01-1023 P95-1026 W99-0613
Experimental results indicate that this combination outperforms the unsupervised boosting method as described in Wu and Wang (2005), achieving a relative error rate reduction of 19.52%.
P05-1058
Experimental results indicate that our semisupervised boosting method outperforms the unsupervised boosting method as described in Wu and Wang (2005), achieving a relative error rate reduction of 19.52%.
P05-1058
Wu and Wang (2005) developed an unsupervised AdaBoost algorithm by automatically building a pseudo reference set for the unlabeled data to improve alignment results.
P05-1058
It is automatically built with a modified "refined" combination method as described in Och and Ney (2000).
P00-1056
Wu and Wang (2005) proved that adding this weight improved the word alignment results.
P05-1058
With the unlabeled data, we train an unsupervised model using the same EM algorithm in Brown et al.(1993). Then we build an interpolation model by linearly interpolating these two word alignment models, which is shown in (8).
J93-2003
Based on the two results, we get the "refined" combination as described in Och and Ney (2000).
P00-1056
Word alignment was first proposed as an intermediate result of statistical machine translation (Brown et al., 1993).
J93-2003
Word Alignment Model According to the IBM models (Brown et al., 1993), the statistical word alignment model can be generally represented as in equation (1).
J93-2003
This simplified version does not take into account word classes as described in Brown et al.(1993). ))))(()](([ ))()](([( )|( )|( )Pr( 0,1 1 0,1 1 11 1 2 0 0 0 00 ∏ ∏ ∏∏ ≠= > ≠= == − −⋅≠ +−⋅= ⋅⋅ ⋅ ⎟ ⎟ ⎠ ⎞ ⎜ ⎜ ⎝ ⎛ − = m aj j m aj j m j aj l i ii m j j j a j jpjdahj cjdahj eften pp m ρ φφ φ φ φ e|fa, (2) ml, are the lengths of the source sentence and the target sentence respectively.
J93-2003
In this paper, with the labeled data, we build a supervised model by directly estimating the parameters in 913 the model instead of using the Expectation Maximization (EM) algorithm in Brown et al.(1993). With the unlabeled data, we build an unsupervised model by estimating the parameters with the EM algorithm.
J93-2003
The Semi-Supervised Adaboost Algorithm for Word Alignment target and target to source) as described in Och and Ney (2000).
P00-1056
cept is defined as the set of target words connected to a source word (Brown et al., 1993).
J93-2003
And the method "Unlabeled+EM+Boost" uses the same unsupervised Adaboost algorithm as described in Wu and Wang (2005).
P05-1058
Thus, we calculate the error rate of each sentence pair as described in (9), which is the same as described in Wu and Wang (2005).
P05-1058
We train the weight in equation (8) in the same way as described in Wu et al.(2005). Pseudo Reference Set for Unlabeled Data ∑∑ ∑ Δ −Δ −Δ =Δ ' 1 ' ' ', '' 1, 1 11 ),( ),( )( jcj cj i i i i cjj cjj jd ρ ρ ρ ρ δ δ (6) ∑∑ ∑ > Δ > > >> −Δ −Δ =Δ ' 1 '' )(, ''' 1 )(, 1 11 ))(,( ))(,( )( jjpj jpj jpjj jpjj jd δ δ (7) The second is the reference set for the unlabeled data.
P05-1058
