document.addEventListener('DOMContentLoaded', () => {
	const API_URL = 'https://jsonplaceholder.typicode.com/comments';
	const SHOW_LIMIT = 50;

	const loadBtn = document.getElementById('load-comments');
	const loadingIndicator = document.getElementById('loading');
	const tableBody = document.querySelector('#comments-table tbody');

	if (!loadBtn || !tableBody) {
		console.warn('Required DOM elements not found. Check that index.html has #load-comments and #comments-table.');
		return;
	}

	function setLoading(is) {
		if (loadingIndicator) loadingIndicator.classList.toggle('hidden', !is);
		loadBtn.disabled = !!is;
	}

	function renderComments(comments) {
		tableBody.innerHTML = '';
		const fragment = document.createDocumentFragment();

		comments.forEach(c => {
			const tr = document.createElement('tr');

			const tdId = document.createElement('td');
			tdId.textContent = c.id;
			tr.appendChild(tdId);

			const tdName = document.createElement('td');
			tdName.textContent = c.name;
			tr.appendChild(tdName);

			const tdEmail = document.createElement('td');
			tdEmail.textContent = c.email;
			tr.appendChild(tdEmail);

			const tdBody = document.createElement('td');
			tdBody.textContent = c.body;
			tr.appendChild(tdBody);

			fragment.appendChild(tr);
		});

		tableBody.appendChild(fragment);
	}

	async function fetchComments() {
		try {
			setLoading(true);
			const res = await fetch(API_URL);
			if (!res.ok) throw new Error(`HTTP ${res.status}`);
			const data = await res.json();
			renderComments(data.slice(0, SHOW_LIMIT));
		} catch (err) {
			if (loadingIndicator) loadingIndicator.textContent = 'Failed to load.';
			console.error('Failed to load comments', err);
		} finally {
			setTimeout(() => setLoading(false), 300);
		}
	}

	loadBtn.addEventListener('click', () => {
		fetchComments();
	});
});

