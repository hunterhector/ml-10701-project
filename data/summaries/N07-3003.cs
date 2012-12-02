Computing Semantic Relatedness Using Wikipedia Semantic relatedness measures have been proven to be useful in many NLP applications such as word sense disambiguation (Kohomban & Lee, 2005; Patwardhan et al., 2005), information retrieval (Finkelstein et al., 2002), information extraction pattern induction (Stevenson & Greenwood, 2005), interpretation of noun compounds (Kim & Baldwin, 2005), paraphrase detection (Mihalcea et al., 2006) and spelling correction (Budanitsky & Hirst, 2006).
P05-1005 P05-1047
P. Ponzetto (2006).
N06-1025
The novel idea presented in Strube & Ponzetto (2006) was to induce a semantic network from the Wikipedia categorization graph to compute measures of semantic relatedness.
N06-1025
baseline system from Soon et al.(2001), and analyzed the performance variations given by including the relatedness measures in the feature set (Figure 2).
J01-4004
We started with the machine learning based 10 WordNet Wikipedia Prince Fela Kuti The Minneapolis Genius the pioneer of Afrobeat music The artist formerly known as Prince TAFKAP The Artist Raw text he Prince Fela Kuti the pioneer of Afrobeat music The Minneapolis Genius he TAFKAP The Artist The artist formerly known as Prince with coreference chains Text annotated Preprocessing pipeline PoS tagger Chunker NER Baseline Feature Extractor MaxEnt classifierSemantic Feature extractor SEMANTICS (Soon et al., 2001) Figure 2: Overview of the coreference system for extrinsic evaluation of WordNet and Wikipedia relatedness measures.
J01-4004
Work: WikiRelate! and Semantic Knowledge Sources for Coreference Resolution Ponzetto & Strube (2006) and Strube & Ponzetto (2006) aimed at showing that ‘the encyclopedia that anyone can edit’ can be indeed used as a semantic resource for research in NLP.
N06-1025
Accordingly, in Ponzetto & Strube (2006) we used a machine learning based coreference resolution system to provide an extrinsic evaluation of the utility of WordNet and Wikipedia relatedness measures for NLP applications.
N06-1025
We start with a baseline system from Soon et al.(2001). We then include at different times features from WordNet and Wikipedia and register performance variations.
J01-4004
This includes extracting semantic relations expressed in the encyclopedic definitions by means of Hearst patterns (Hearst, 1992), detection of semantic variations (Morin & Jacquemin, 1999) between category labels, as well as using the categorized pages as bag-of-words to compute scores of idf-based semantic overlap (Monz & de Rijke, 2001) between categories.
C92-2082 P99-1050
