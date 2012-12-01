In other directions, we will try to improve our WP-based STW conversion with other types of WP data, such as NEVF and MWP (Tsai et al.2002 and 2004), and statistical language models, such as HMM, and extend it to other areas of NLP, especially word segmentation and the mix-WP identifier from the word lattice of Chinese speech recognition systems.
C02-1089
Conventionally, there are two approaches for STW conversion: (1) the linguistic approach based on syntax parsing, semantic template matching and contextual information (Hsu 1994, Fu et al.1996, Hsu et al.1999, Kuo 1995, Tsai and Hsu 2002); and (2) the statistical approach based on the n-gram models where n is usually 2 or 3 (Lin and Tsai 1987, Gu et al.1991, Fu et al.1996, Ho et al.1997, Sproat 1990, Gao et al.2002, Lee 2003).
C02-1089
According to (Fong and Chung 1994, Tsai and Hsu 2002), homophone selection and syllable-word segmentation are two critical problems to the STW conversion in Chinese.
C02-1089
STW Experiments To evaluate the STW performance of our mixWP identifier, the STW accuracy, the identified character ratio (ICR) and the STW improvement were used (Tsai 2005).
I05-3002
Tsai, J.L. 2005.
I05-3002
In addition, an optimized bigram model called BiGram was developed (Tsai et al.2004). The BiGram STW system is a bigram-based model developing by SRILM (Stolcke 2002) with Good-Turing back-off smoothing (Manning and Schuetze, 1999), as well as forward and backward LS-WPF strategies (Chen et al.1986, Tsai et al.2004). The training corpus and the system dictionary of this BiGram system are same with that of the mix-WP identifier.
C02-1089
Since the size of problem space for syllable-to-word (STW) conversion is much less than that of syllable-tocharacter (STC) conversion, the most existing Chinese input systems (Hsu 1994, Hsu et al.1999, Tsai and Hsu 2002, Gao et al.2002, MSIME) are addressed on STW conversion.
C02-1089
Although the linguistic approach requires considerable effort in designing effective syntax rules, semantic templates or contextual information, it is more user-friendly than the statistical approach on understanding why such a system makes a mistake (Hsu 1994, Tsai and Hsu 2002).
C02-1089
If applying the CWP identifier on the syllables “yi1 ge5 wen2 ming2 de5 shuai1 wei2 guo4 cheng2(一個 [a]文明 [civilization]的 [of]衰微 [decay] 過程 [process]),” the generated WPsentence will be “一個文明 de5shuai1wei2 過 程.” For the same syllables, the MSIME will convert them into “一個 [a]聞名 [famous]的 [of] 衰微 [decay]過程 [process].” The detailed analysis and demonstration of our CWP identifier can be found in (Tsai 2005).
I05-3002
