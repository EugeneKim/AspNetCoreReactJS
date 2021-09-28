import React, { useState } from 'react';

const App: React.FC = () => {

	const [content, setContent] = useState("Click the button above.");

	const handleClickAsync = async() => {
		const response = await fetch("http://localhost:5000/weatherforecast");
		const content = await response.json();
		setContent(JSON.stringify(content));
	}

	return <>
		<button type="button" onClick={handleClickAsync}>Fetch!</button>
		<p>{content}</p>
	</>
}

export default App;
