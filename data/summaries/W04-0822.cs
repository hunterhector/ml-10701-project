Earlier experiments on Senseval-2 data showed that the KPCA-based model significantly outperformed both na¨ıve Bayes and maximum entropy models (Wu et al., 2004).
P04-1081
For WSD and indeed many natural language tasks, significant accuracy gains can often be achieved by generalizing over relevant feature combinations (see, e.g., Kudo and Matsumoto (2003)).
P03-1004
KPCA-based WSD model We briefly summarize the KPCA-based model here; for full details including illustrative examples and graphical interpretation, please refer to Wu et al.(2004). Kernel PCA Kernel Principal Component Analysis is a nonlinear kernel method for extracting nonlinear principal components from vector sets where, conceptually, the n-dimensional input vectors are nonlinearly mapped from their original space Rn to a high-dimensional feature space F where linear PCA is performed, yielding a transform by which the input vectors can be mapped nonlinearly to a new set of vectors (Sch¨olkopf et al., 1998).
P04-1081
The new WSD model, proposed by Wu et al.(2004), is a method for disambiguating word senses that exploits a nonlinear Kernel Principal Component Analysis (KPCA) technique.
P04-1081
Then the lth nonlinear principal component of any test vector xt is defined as ylt = MX i=1 ^ li ( (xi) (xt )) (6) where ^ li is the lth element of ^ l. See Wu et al.(2004) for a possible geometric interpretation of the power of the nonlinearity.
P04-1081
The second voting model, a maximum entropy model (Jaynes, 1978), was built as Klein and Manning (2002) found that it yielded higher accuracy than na¨ıve Bayes in a subsequent comparison of WSD performance.
W02-1002
The third voting model, a boosting model (Freund and Schapire, 1997), was built as boosting has consistently turned in very competitive scores on related tasks such as named entity classification (Carreras et al., 2002)(Wu et al., 2002).
W02-2004 W02-2035
Some of these component models were also evaluated on other Senseval-3 tasks: the Basque, Catalan, Italian, and Romanian Lexical Sample tasks (Wicentowski et al., 2004), as well as Semantic Role Labeling (Ngai et al., 2004).
W04-0845 W04-0863
