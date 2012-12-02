Finally, Garera and Yarowsky (2006) propose an association-based approach using nouns that occur in a 2-sentence window before a definite description that has no same-head antecedent.
W06-2906
Weeds and Weir (2005) discuss the influence of bias towards highor low-frequency items for different tasks (correlation with WordNet-derived neighbour sets and pseudoword disambiguation), and it would not be surprising if the different high-frequency bias were leading to different results.
J05-4002
We also reimplemented the approach of Garera and Yarowsky (2006), who extract potential anaphor-antecedent pairs from unlabeled texts and rank these potentially related pairs by the mutual information statistic.
W06-2906
Harabagiu et al.(2001) use paths through Wordnet, using not only synonym and is-a relations, but also parts, morphological derivations, gloss texts and polysemy, which are weighted with a measure based on the relation types and number of path elements.
N01-1008
Other approaches use large corpora to get an indication for bridging relations: Poesio et al.(1998) use a general word association metric based on common terms occuring in a fixed-width window, Gasperin and Vieira (2004) use syntactic contexts of words in a large corpus to induce a semantic similarity measure (similar to the one introduced by Lin, 1998), and then use lists of the n nouns that are (globally) most similar to a given noun.
P98-2127 W04-0706
For the last approach, where dependency relations were needed but labeling accuracy was not as important, we used a deterministic shift-reduce parser that Foth and Menzel (2006) used as input source in hybrid dependency parsing.3 For all three approaches, we lemmatised the words by using a combination of SMOR (Schmid et al., 2004), a derivational finite-state morphology for German, and lexical information derived from the lexicon of a German dependency parser (Foth and Menzel, 2006).
P06-1041
Coreference resolution, the task of grouping mentions in a text that refer to the same referent in the real world, has been shown to be beneficial for a number of higher-level tasks such as information extraction (McCarthy and Lehnert, 1995), question answering (Morton, 2000) and summarisation (Steinberger et al., 2005).
H05-1001 P00-1023
The other cases, called coreferent bridging by Vieira and Poesio1, are notably harder because the number of potential candidates is much 1Because bridging (in the sense of Clark, 1975, or Asher and larger when it is no longer possible to rely on surface similarity.
T75-2034
Although state of the art methods for modular discourse-new detection (Uryupina, 2003; Poesio et al., 2005) do not achieve near-perfect accuracy for discourse-new detection, the results we give for antecedent selection represent an upper bound on recall and precision for the full coreference task, and we think that this upper bound will be useful for Lascarides, 1998) is a much broader concept, the term ‘coreferent bridging’ is potentially confusing, as many cases are examples of perfectly well-behaved anaphoric definite noun phrases.
P03-2012
To overcome the limit of recall that is encountered when only relying on surface features, newer systems for coreference resolutions (Daum´e III and Marcu, 2005; Ponzetto and Strube, 2006; Versley, 2006; Ng, 2007, inter alia) use lexical semantic information as an indication for semantic compatibility in the absence of head equality.
N06-1025
However, while similarity measures (such as WordNet distance or Lin’s similarity metric) only detect cases of semantic similarity, association measures (such as the ones used by Poesio et al., or by Garera and Yarowsky) also find cases of associative bridg497 Lin98 RFF TheY TheY:G2 PL03 Land (country/state/land) Staat Staat Kemalismus Regierung Kontinent state state Kemalism government continent Stadt Stadt Bauernfamilie Pr¨asident Region city city agricultural family president region Region Landesregierung Bankgesellschaft Dollar Stadt region country government banking corporation dollar city Bundesrepublik Bundesregierung Baht Albanien Staat federal republic federal government Baht Albania state Republik Gewerkschaft Gasag Hauptstadt Bundesland republic trade union (a gas company) capital state Medikament (medical drug) Arzneimittel Pille RU Patient Arzneimittel pharmaceutical pill (a drug∗) patient pharmaceutical Pr¨aparat Droge Abtreibungspille Arzt Lebensmittel preparation drug (non-medical) abortion pill doctor foodstuff Pille Pr¨aparat Viagra Pille Pr¨aparat pill preparation Viagra pill preparation Hormon Pestizid Pharmakonzern Behandlung Behandlung hormone pesticide pharmaceutical company treatment treatment Lebensmittel Lebensmittel Pr¨aparat Abtreibungspille Arznei foodstuff foodstuff preparation abortion pill drug highest ranked words, with very rare words removed ∗: RU 486, an abortifacient drug Lin98: Lin’s distributional similarity measure (Lin, 1998) RFF: Geffet and Dagan’s Relative Feature Focus measure (Geffet and Dagan, 2004) TheY: association measure introduced by Garera and Yarowsky (2006) TheY:G2: similar method using a log-likelihood-based statistic (see Dunning 1993) this statistic has a preference for higher-frequency terms PL03: semantic space association measure proposed by Pad´o and Lapata (2003) Table 1: Similarity and association measures: most similar items ing like 1a,b; the result of this can be seen in table (2): while the similarity measures (Lin98, RFF) list substitutable terms (which behave like synonyms in many contexts), the association measures (Garera and Yarowsky’s TheY measure, Pad´o and Lapata’s association measure) also find non-compatible associations such as country–capital or drug–treatment, which is why they are commonly called relationfree.
J93-1003 P98-2127 W06-2906
CoLing/ACL 1998.
P98-2127
on Antecedent Selection In a setting similar to Markert and Nissim (2005), we evaluate the precision (proportion of correct cases in the resolved cases) and recall (correct cases to all cases) for the resolution of discourse-old definite noun phrases.
J05-3004
The measures both of Lin (1998) and of Pad´o and Lapata (2003, 2007) are distributional methods; for each word, they create a distribution of the contexts they occur in, and similarity between two words is calculated as the similarity of these distributions.2 The difference in these two methods is the representation of the contexts.
P98-2127
The system of Cardie and Wagstaff (1999) uses the node distance in WordNet (with an upper limit of 4) as one component in the distance measure that guides their clustering algorithm.
W99-0611
and Future Work Both the distributional similarity statistics and the association measure can profit from more training data, something which is bound by availability of similar text (Gasperin et al., 2004 point out that using texts from a different genre strongly limits the usefulness of the learned semantic similarity measure), and by processing costs (which are more serious for distributional similarity measures than for non-grammar-related association measures, as the former necessitate parsed input).
W04-0706
In contrast to earlier investigations (Markert and Nissim, 2005; Garera and Yarowsky, 2006), we provide a more extensive overview on features and also discuss properties that influence their combinability.
J05-3004 W06-2906
Using the framework of Weeds et al.(2004), we found that the bias of lower frequency words for preferring high-frequency neighbours was higher for RFF (0.58 against 0.35 for Lin’s measure).
C04-1146
Markert and Nissim (2005) mine the World Wide Web for shallow patterns like “China and other countries”, indicating an is-a relationship.
J05-3004
Poesio et al.(1997) use WordNet, looking for a synonymy or hypernymy relation (additionally, for coordinate sisters in WordNet).
W97-1301
Very interestingly, the distributional methods based on intra-sentence relations (Lin, 1998; Pad´o and Lapata, 2003) outperformed Garera and Yarowsky’s (2006) association measure when used for ranking, which may due to sparse data problems or simply too much noise for the latter.
P98-2127 W06-2906
Additionally, we included an approach due to Gasperin and Vieira (2004), who tackle the problem of similarity by using lists of most similar words to a certain word, based on a similarity measure closely related to Lin’s.
W04-0706
While the resolution of pronominal anaphora and tracking of named entities is possible with good accuracy, the resolution of definite NPs (having a common noun as their head) is usually limited to the cases that Vieira and Poesio (2000) call direct coreference, where both coreferent mentions have the same head.
J00-4003
Starting with the combination of GermaNet and patternbased search on the World Wide Web, we begin by adding the distance-bounded semantic similaritybased resolver (LinBnd) and resolution based on the list of 25 most similar words (following the 502 approach of Gasperin and Vieira 2004).
W04-0706
For our experiments, we used the first 125 articles of the coreferentially annotated T¨uBa-D/Z corpus of written newspaper text (Hinrichs et al., 2005), totalling 2239 sentences with 633 discourse-old definite descriptions, and the latest release of GermaNet (Kunze and Lemnitzer, 2002), which is the Germanlanguage part of EuroWordNet.
W05-0303
See Weeds and Weir (2005) for an overview of other measures.
J05-4002
