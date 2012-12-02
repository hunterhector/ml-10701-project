In this paper, the same feature as in Shen et al 2003 is used.
W03-1307
Shen et al 2003 proposes a HMM-based approach and two post-processing modules (cascaded entity name resolution and abbreviation resolution).
W03-1307
Table 2 shows the performance of our system on GENIA V1.1 and GENIA V3.0, and the comparison with that of the best reported system (Shen et al 2003).
W03-1307
• Morphological Pattern (F MP ): Morphological information, such as prefix and suffix, is considered as an important cue for terminology identification and has been widely applied in the biomedical domain (Kazama et al 2002; Lee et al 2003; Shen et al 2003; Zhou et al 2004).
W02-0301 W03-1305 W03-1307
Here, we use the Hidden Markov Model (HMM) as described in Zhou et al 2002.
P02-1060
Same as Shen et al 2003, we use a statistical method to get the most useful prefixes/suffixes from the training data.
W03-1307
The typical explorations include Kazama et al 2002, Lee et al 2003, Tsuruoka et al 2003, Shen et al 2003.
W02-0301 W03-1305 W03-1306 W03-1307
Tsuruoka et al 2003 applies a dictionary-based approach and a naïve Bayes classifier to filter out false positives.
W03-1306
It also shows that our system outperforms Shen et al (2003) by 6.9 in F-measure on GENIA V1.1 and 4.6 in F-measure on GENIA V3.0.
W03-1307
Cascaded Entity Name Resolution It is found (Shen et al 2003) that 16.57% of entity names in GENIA V3.0 have cascaded constructions, e.g.
W03-1307
Kazama et al 2002 applies SVM and incorporates a rich feature set, including word feature, POS, prefix feature, suffix feature, previous class feature, word cache feature and HMM state feature.
W02-0301
Lee et al 2003 uses a two phase SVM-based recognition approach and incorporates word formation pattern and part-ofspeech.
W03-1305
This feature has been widely used in the biomedical domain (Kazama et al 2002; Shen et al 2003; Zhou et al 2004).
W02-0301 W03-1307
This is largely due to the superiority of the SVM plus sigmoid in our system (improvement of 3.7 in F-measure on GENIA V3.0) over the back-off approach in Shen et al (2003) and the novel name alias feature (improvement of 1.2 in F-measure on GENIA V3.0).
W03-1307
In ngram modeling (Chen et al 1996), each tag is assumed to be dependent on the N-1 previous tags.
P96-1041
Generally, two smoothing approaches (Chen et al 1996) are applied to resolve this problem: linear interpolation and back-off.
P96-1041
In recent years, many explorations have been done to port existing named entity recognition systems into the biomedical domain (Kazama et al 2002; Lee et al 2003; Shen et al 2003; Zhou et al 2004).
W02-0301 W03-1305 W03-1307
