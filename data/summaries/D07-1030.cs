We use the same method described in (Koehn and Monz, 2006) to perform the significance test.
W06-3114
Nomoto (2004) used voted language models to select the best output string at sentence level.
P04-1063
We run the decoder with its default settings (maximum phrase length 7) and then use Koehn's implementation of minimum error rate training (Och, 2003) to tune the feature weights on the de2 The full name of HTRDP is National High Technology Research and Development Program of China, also named as 863 Program.
N03-1017 P03-1021
Evaluation According to (Koehn and Monz, 2006; CallisonBurch et al., 2006), the RBMT systems are usually not adequately appreciated by BLEU.
W06-3114
In our experiments using BLEU (Papineni et al., 2002) as the metric, the interpolated synthetic model achieves a relative improvement of 11.7% over the best RBMT system that is used to produce the synthetic bilingual corpora.
P02-1040
SMT has evolved from the original word-based approach (Brown et al., 1993) into phrase-based approaches (Koehn et al., 2003; Och and Ney, 2004) and syntax-based approaches (Wu, 1997; Alshawi et al., 2000; Yamada and Knignt, 2001; Chiang, 2005).
J00-1004 J04-4002 J93-2003 J97-3002 N03-1017 P01-1067 P05-1033
Some research focused on the hybrid of various corpus-based MT methods, such as SMT and EBMT (Vogel and Ney, 2000; Marcu, 2001; Groves and Way, 2006; Menezes and Quirk, 2005).
C00-2172 P01-1050
Some recent approaches to MEMT used word alignment techniques for comparison between the MT systems (Jayaraman and Lavie, 2005; Zaanen and Somers, 2005; Matusov et al.2006). All the above MEMT systems operate on MT outputs for complete input sentences.
E06-1005 P05-3026
We also manually evaluated the RBMT systems and SMT systems in terms of both adequacy and fluency as defined in (Koehn and Monz, 2006).
W06-3114
The translation quality is evaluated using a well-established automatic measure: BLEU score (Papineni et al., 2002).
P02-1040
Chris Callison-Burch, Miles Osborne and Philipp Koehn, 2006.
W06-3114
3.1 Phrase-Based Models According to the translation model presented in (Koehn et al., 2003), given a source sentence f, the best target translation can be obtained using the following model best e 288 )( )()(maxarg )(maxarg | | e e e eef fee length LM best ωpp p = = (1) Where the translation model can be decomposed into )( | efp ∏ = − −= I i i iii i i II aefpbadef efp 1 1 1 1 ),|()()|( )|( λ φ w (2) Where )|( i i efφ is the phrase translation probability.
N03-1017
Frederking and Nirenburg (1994) produced the first MEMT system by combining outputs from three different MT engines based on their knowledge of the inner workings of the engines.
A94-1016
