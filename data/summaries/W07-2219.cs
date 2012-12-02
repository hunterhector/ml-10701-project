To illustrate the extent and the complexity of that matter let us consider definiteness in MH, which is morphologically marked (as an h prefix to the stem, glossed here explicitly as “the-”) and behaves as a syntactic 3See (Wintner, 2000) and (Goldberg et al., 2006) for formal and statistical accounts (respectively) of noun phrases in MH.
P06-1087
of Unlexicalized Parsing Probabilistic Context Free Grammars (PCFGs) are the formal backbone of most high-accuracy statistical parsers for English, and a variety of techniques was developed to enhance their performance relative to the na¨ıve treebank implementation — from unlexicalized extensions exploiting simple category splits (Johnson, 1998; Klein and Manning, 2003) to fully lexicalized parsers that condition events below a constituent upon the head and additional lexical content (Collins, 2003; Charniak, 1997).
J03-4003 J98-4004 P03-1054
The methodology we use is adopted from (Klein and Manning, 2003) and our procedure is identical to the one described in (Johnson, 1998).
J98-4004 P03-1054
Johnson (1998) augments node labels with the label of their parent, thus incorporating a dependency on the node’s grandparent.
J98-4004
◦ ri−1) = ∅) and h = ∞ (RHS cannot decompose) is, according to Klein and Manning (2003), a historical accident.
P03-1054
This two-dimensional parametrization has been instrumental in devising parsing models that improve disambiguation capabilities for English as well as other languages, such as German (Dubey and Keller, 2003) Czech (Collins et al., 1999) and Chinese (Bikel and Chiang, 2000).
P03-1013 P99-1065 W00-1201
We report the results within an integrated model for morphological and syntactic disambiguation in the spirit of (Tsarfaty, 2006).
P06-3009
7A formal overview of the transformation and its correspondence to (Collins, 2003)’s models is available at (Hageloh, 2007).
J03-4003
Abney. 1997.
J97-4005
In a second set of experiments we use an unlexicalized headdriven baseline `a la (Collins, 2003) located on the (0,0,0) coordinate.
J03-4003
The factor that sets apart vanilla PCFGs (Charniak, 1996) from their unlexicalized extensions proposed by, e.g., (Johnson, 1998; Klein and Manning, 2003), is the choice for statistical parametrization that weakens the independence assumptions implicit in the treebank grammar.
J98-4004 P03-1054
Work The MH treebank (Sima’an et al., 2001), a morphologically and syntactically annotated corpus, has been successfully used for various NLP tasks such as morphological disambiguation, POS tagging (BarHaim et al., 2007) and NP chunking (Goldberg et al., 2006).
P06-1087
While it is clear that conditioning on lexical content improves the grammar’s disambiguation capabilities, Klein and Manning (2003) demonstrate that a wellcrafted unlexicalized PCFG can close the gap, to a large extent, with current state-of-the-art lexicalized parsers for English.
P03-1054
This results in several aspects that distinguish the MH treebank from, e.g., the WSJ Penn treebank annotation scheme (Marcus et al., 1994).
H94-1020
Figure 6(b) illustrates how the depth expansion interacts with both parent anno160 (a) The horizontal/vertical Grid (b) The vertical dimension (c) The horizontal dimension Figure 5: The Two-Dimensional Space: The horizontal and vertical dimensions outlined by (Klein and Manning, 2003) tation and neighbor dependencies thereby affecting both distributions.
P03-1054
(Due to the small size of our data set we only use the values {0,1} as possible instantiations.) The v dimension is implemented using a transform as in (Johnson, 1998) where v = 0 corresponds to bare syntactic categories and v = 1 augments node labels with the label of their parent node.
J98-4004
For each instantiation we transform the training set and learn a PCFG using Maximum Likelihood estimates, and we use BitPar (Schmidt, 2004), an efficient general-purpose parser, to parse unseen sentences.
C04-1024
(Abney, 1997)) and has the advantage of elegantly bypassing the issue of loosing probability mass to failed derivations due to unification failures.
J97-4005
the Parameter Space (Klein and Manning, 2003) argue that parent encoding on top of syntactic categories and RHS markovization of CFG productions are two instances of the same idea, namely that of encoding the generation history of a node to a varying degree.
P03-1054
Also, the MH treebank is much smaller than the ones for, e.g., English (Marcus et al., 1994) and Arabic (Maamouri and Bies, 2004), making it hard to apply data-intensive methods such as the allsubtrees approach (Bod, 1992) or full lexicalization (Collins, 2003).
H94-1020 J03-4003 W04-1602
Our best model uses all three dimensions of parametrization, and our best re1The learning curves over increasing training data (e.g., for German (Dubey and Keller, 2003)) show that treebank size cannot be the sole factor to account for the inferior performance.
P03-1013
Note on State-Splits Recent studies (Klein and Manning, 2003; Matsuzaki et al., 2005; Prescher, 2005; Petrov et al., 2006) suggest that category-splits help in enhancing the performance of treebank grammars, and a previous study on MH (Tsarfaty, 2006) outlines specific POS-tags splits that improve MH parsing accuracy.
P03-1054 P05-1010 P06-1055 P06-3009 W05-1512
The first, proposed by (Johnson, 1998), is the annotation of parental history, and the second encodes a head-outward generation process (Collins, 2003).
J03-4003 J98-4004
This dimension is orthogonal to the vertical (Collins, 2003) and horizontal (Johnson, 1998) dimensions previously outlined by Klein and Manning (2003), and it cannot be collapsed into any one of the previous two.
J03-4003 J98-4004 P03-1054
156 Klein and Manning (2003) systematize the distinction between these two forms of parametrization by drawing them on a horizontal-vertical grid: parent encoding is vertical (external to the rule) whereas head-outward generation is horizontal (internal to the rule).
P03-1054
Collins (2003) proposes to generate the head of a phrase first and then generate its sisters using Markovian processes, thereby exploiting head/sister-dependencies.
J03-4003
By varying the value of the parameters along the grid, Klein and Manning (2003) tune their treebank grammar to achieve improved performance.
P03-1054
In our next set of experiments we evaluate the contribution of the depth dimension to extensions of the head-driven unlexicalized variety `a la (Collins, 2003).
J03-4003
Our best performing model incorporates three dimensions of parametrization and our best result (75.25%) is similar to the one obtained by the parser of (Bikel, 2004) for Modern Standard Arabic (75%) using a fully lexicalized model and a training corpus about three times as large as our newest MH treebank.
J04-4004
To implement h negationslash= ∞ we use a PCFG transformation emulating (Collins, 2003)’s first model, in which sisters are generated conditioned on the head tag and a simple ‘distance’ function (Hageloh, 2007).7 The inprocess.
J03-4003
The only previous studies attempting to parse MH we know of are (Sima’an et al., 2001), applying a variation of the DOP tree-gram model to 500 sentences, and (Tsarfaty, 2006), using a treebank PCFG in an integrated system for morphological and syntactic disambiguation.9 The adaptation of state-of-the-art parsing models to MH is not immediate as the flat variable structures of phrases are hard to parse and a plentiful of morphological features that would facilitate disambiguation are not exploited by currently available parsers.
P06-3009
Klein and Manning (2003) view the vertical and horizontal parametrization dimensions as implementing external and internal annotation strategies respectively.
P03-1054
