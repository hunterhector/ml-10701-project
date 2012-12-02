Abney (1997) pointed out that the non-contextfree dependencies of a uni cation grammar require stochastic models more general than Probabilistic Context-Free Grammars (PCFGs) and Markov Branching Processes, and proposed the use of loglinear models for de ning probability distributions over the parses of a uni cation grammar.
J97-4005
Johnson et al.(1999) observed that parsing and related tasks only require conditional distributions over parses given strings, and that such conditional distributions are considerably easier to estimate than joint distributions of strings and their parses.
P99-1069
A property is a real-valued function of parses. Johnson et al.(1999) placed no restrictions on what functions could be properties, permitting properties to encode arbitrary global information about a parse.
P99-1069
The following section reviews stochastic uni cation grammars (Abney, 1997) and the statistical quantities required for ef ciently estimating such grammars from parsed training data (Johnson et al., 1999).
J97-4005 P99-1069
For a more detailed exposition and descriptions of regularization and other important details, see Johnson et al.(1999). The probability distribution over parses is de ned in terms of a nite vector g = (g1;::: ;gm) of properties.
P99-1069
As explained in Johnson et al.(1999), one way to do this is to nd the that maximises the conditional likelihood of the training corpus parses given their yields.
P99-1069
