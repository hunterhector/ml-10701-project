SYNTACTIC PARSING The parsing algorithm described here is implemented in the Gemini spoken-language under110 standing system (Dowding et al., 1993), which features a broad-coverage unification-based grammar of English, with independent syntactic, semantic and lexical components, in the style of the SRI Core Language Engine (Alshawi, 1992).
P93-1008
Earlier work (Moore and Dowding, 1991) showed that over 80% of the edges built by a bottom-up parser using our grammar were in this class.
H91-1036
Other optimizations include using one-word look-ahead before adding new predictions, and using restrictors (Shieber, 1985) to increase the generality of the predictions.
P85-1018
In previous work (Moore and Dowding, 1991), we compared limited left-context checking to some other methods for dealing with empty categories in a bottom-up parser.
H91-1036
are important differences between the technique for limited prediction in this parser, and other techniques for limited prediction such as Shieber's notion of restriction (Shieber, 1985) (which we also use).
P85-1018
